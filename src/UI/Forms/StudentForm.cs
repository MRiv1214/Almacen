using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.Dtos;
using Almacen.Helpers;
using Almacen.Repository.Sqlite;
using Almacen.Models.AutoGen;
using System.Text;

namespace Almacen.UI.Forms;
public static class StudentForm
{
    public static byte[] CreateStudent(long UserId, long CareerId)
    {
        AnsiConsole.Markup("[blue]Sign Up[/]\n");
        var Register = AnsiConsole.Ask<string>("Enter your Register:");
        var studentDto = new StudentDto
        {
            Register = Encoding.UTF8.GetBytes(Register),
            UserId = UserId,
            CareerId = CareerId,
        };
        var studentRepository = new SqliteRepository<Student>(AlmacenContext.GetInstance());
        var studentController = new StudentController(studentRepository);
        return studentController.CreateStudent(studentDto);
    }
}
