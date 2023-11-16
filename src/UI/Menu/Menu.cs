using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Controllers;
using Almacen.Models.AutoGen;
using Almacen.Repository.Sqlite;

namespace UI.Menu;

public class Menu : IView
{
    // instanciar el repositorio de usuario
    private static readonly SqliteRepository<Employee> userRepository = new(AlmacenContext.GetInstance());
    private static readonly EmployeeController employeeController = new(userRepository);
    private static readonly SqliteRepository<Student> studentRepository = new(AlmacenContext.GetInstance());
    private static readonly StudentController studentController = new(studentRepository);
    public static void MainMenu(User user)
    {
        var employee = employeeController.GetEmployeeByUserId(user.UserId);
        var student = studentController.GetStudentById(user.UserId);

        if (employee == null) {
            StudentMenu.Student_Menu();
        } else {
            switch (employee.UserType) {
            case 1: //Admin
                AdminMenu.Admin_Menu();
                break;
            case 2: //Teacher
                TeacherMenu.Teacher_Menu();
                break;
            case 3: //Student
                AdminMenu.Admin_Menu();
                break;
            }
        }

    }

    public void DoOption(string option)
    {
        throw new NotImplementedException();
    }

    public string GetOption()
    {
        throw new NotImplementedException();
    }
}
