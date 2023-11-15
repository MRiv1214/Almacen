using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Repository.Sqlite;
using Almacen.Models.AutoGen;

namespace UI.Forms;

public class CareerForm : IView
{
    private static readonly SqliteRepository<Career> careerRepository = new(AlmacenContext.GetInstance());
    private static readonly CareerController careerController = new(careerRepository);
    public static long CreateCareer()
    {
        var name = AnsiConsole.Ask<string>("Enter career name:");
        var careerDto = new CareerDto
        {
            Name = name,
        };
        var CareerId = careerController.CreateCareer(careerDto);
        return CareerId;
    }
    public static long SelectCareer()
    {
        var careers = careerController.GetAllCareers();
        var careersName = new List<string>();
        foreach (var career in careers)
        {
            careersName.Add(career.Name!);
        }
        var careerName = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select a career")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more careers)[/]")
            .AddChoices(careersName));

        return careerController.GetCareerByName(careerName).CareerId;
    }

    public static void UpdateCareer()
    {
        AnsiConsole.Markup("[blue]Update Career[/]\n");
        var careerId = SelectCareer();
        var name = AnsiConsole.Ask<string>("Enter career name:");
        var career = new Career
        {
            Name = name,
        };
        careerController.UpdateCareer(career);
    }

    public static void RemoveCareer()
    {
        AnsiConsole.Markup("[blue]Remove Career[/]\n");
        careerController.RemoveCareer(SelectCareer());
    }

    public string GetOption()
    {
        throw new NotImplementedException();
    }

    public void DoOption(string option)
    {
        throw new NotImplementedException();
    }
}
