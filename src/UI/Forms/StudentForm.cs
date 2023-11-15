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

namespace UI.Forms;
public class StudentForm : View
{
    private static readonly SqliteRepository<Student> studentRepository = new(AlmacenContext.GetInstance());
    private static readonly StudentController studentController = new(studentRepository);
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

    public static byte[] SelectStudent()
    {
        var students = studentController.GetAllStudents();
        var studentsRegister = new List<string>();
        foreach (var student in students)
        {
            studentsRegister.Add(Encoding.UTF8.GetString(student.Register!));
        }
        var studentRegister = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select a student")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more students)[/]")
            .AddChoices(studentsRegister));
        byte[] studentRegisterBytes = Encoding.UTF8.GetBytes(studentRegister);
        return studentController.GetStudentByRegister(studentRegisterBytes)!.Register!;
    }

    public static byte[] UpdateStudent()
    {
        AnsiConsole.Markup("[blue]Update Student[/]\n");
        var studentRegister = SelectStudent();
        var Register = AnsiConsole.Ask<string>("Enter your Register:");
        var student = new Student
        {
            Register = Encoding.UTF8.GetBytes(Register),
        };
        studentController.UpdateStudent(student);
        return studentRegister;
    }

    public static void RemoveStudent()
    {
        AnsiConsole.Markup("[blue]Remove Student[/]\n");
        studentController.RemoveStudent(SelectStudent());
    }
}
