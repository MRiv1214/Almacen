using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen.UI.Forms;

public class EmployeeForm
{
    public void CreateEmployee(string typeOfUser)
    {
        switch (typeOfUser)
        {
            case "Student":
                CreateStudent();
                break;
            case "Employee":
                CreateCoordinator();
                break;
            case "Teacher":
                CreateTeacher();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    public void CreateTeacher()
    {
        Console.WriteLine("Create Teacher");
    }
    public void CreateStoreKeeper()
    {
        Console.WriteLine("Create StoreKeeper");
    }
    public void CreateCoordinator()
    {
        Console.WriteLine("Create Coordinator");
    }
    public void CreateStudent()
    {
        Console.WriteLine("Create Student");
    }
}

