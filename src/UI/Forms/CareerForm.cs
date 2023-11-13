using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Helpers;
using Almacen.Repository.Sqlite;
using Almacen.Models.AutoGen;

namespace Almacen.UI.Forms;

public class CareerForm
{
    public static long CreateCareerForm()
    {
        var name = AnsiConsole.Ask<string>("Enter your name:");
        var careerDto = new CareerDto
        {
            Name = name,
        };
        var careerRepository = new SqliteRepository<Career>(AlmacenContext.GetInstance());
        var careerController = new CareerController(careerRepository);
        var CareerId = careerController.CreateCareer(careerDto); 
        return CareerId;
    }
    public static long SelectCareer()
    {
        AnsiConsole.Markup("[blue]Sign Up[/]\n");
        var careerRepository = new SqliteRepository<Career>(AlmacenContext.GetInstance());
        var careerController = new CareerController(careerRepository);
        var careers = careerController.GetAllCareers();
        var careersName = new List<string>();
        foreach (var career in careers)
        {
            careersName.Add(career.Name);
        }
        var careerName = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select a career")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more careers)[/]")
            .AddChoices(careersName));
                        
        return careerController.GetCareerByName(careerName).CareerId;
    }
}
