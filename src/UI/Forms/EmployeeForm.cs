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
            case "Admin":

                CreateCoordinator();
                break;
            case "Teacher":
                Create();
                break;
            case "StoreKeeper":
                CreateStoreKeeper();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    public void Create()
    {
        
    }
    public void CreateStoreKeeper()
    {
        Console.WriteLine("Create StoreKeeper");
    }
    public void CreateCoordinator()
    {
        Console.WriteLine("Create Coordinator");
    }
}

