using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almacen.Models.AutoGen;
using UI.Menu;

namespace UI.Menu;

public class AdminMenu
{
    //SUBMENU EMPLOYEE: Create, View, Update, Delete
    //SUBMENU STUDENT: Create, View, Update, Delete
    //SUBMENU MATERIAL: Create, View, Update, Delete
    //SUBMENU MATERIAL MAINTENANCE: Create, View, Update, Delete
    //SUBMENU REQUEST: View, Delete, UPDATE
    //SUBMENU CLASSROOM: Create, View, Update, Delete
    //SUBMENU GROUP: Create, View, Update, Delete
    //SUBMENU SUBJECT: Create, View, Update, Delete 

    public const string Employee = "Employee", Student = "Student", MaterialMaintenance = "Material Maintenance",
    Material = "Material", Request = "Request", Classroom = "Classroom", Group = "Group", Subject = "Subject", Exit = "Exit";
    public static void Admin_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(10)
                .AddChoices(new[] {
                    Employee, Student, MaterialMaintenance, Material, Request, Classroom, Group, Subject, Exit
        }));
        switch (userSelection)
        {
            case Employee:
                Employee_Menu();
                break;
            case Student:
                Student_Menu();
                break;
            case Material:
                MaterialMenu.Material_Menu();
                break;
            case MaterialMaintenance:
                MaterialMaintenanceMenu.MaterialMaintenance_Menu();
                break;
            case Request:
                RequestMenu.Request_General_Menu();
                break;
            case Classroom:
                Classroom_Menu();
                break;
            case Group:
                Group_Menu();
                break;
            case Subject:
                Subject_Menu();
                break;
            case Exit:
                Environment.Exit(0);
                break;
        }
    }

    public const string CreateEmployee = "Create Employee", ViewEmployee = "View Employee", 
    UpdateEmployee = "Update Employee", DeleteEmployee = "Delete Employee", Back = "Back";
    public static void Employee_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(4)
                .AddChoices(new[] {
                    CreateEmployee, ViewEmployee, UpdateEmployee, DeleteEmployee, Back, Exit
        }));
        switch (userSelection)
        {
            case CreateEmployee:
                // CreateEmployee();
                break;
            case ViewEmployee:
                // ViewEmployee();
                break;
            case UpdateEmployee:
                // UpdateEmployee();
                break;
            case DeleteEmployee:
                // DeleteEmployee();
                break;
            case Back:
                Admin_Menu();
                //YA TAN BIEN
                break;
            case Exit:
                Environment.Exit(0);
                break;
        }
    }

    public const string CreateStudent = "Create Student", ViewStudent = "View Student", 
    UpdateStudent = "Update Student", DeleteStudent = "Delete Student";
    public static void Student_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(6)
                .AddChoices(new[] {
                    CreateStudent, ViewStudent, UpdateStudent, DeleteStudent, Back, Exit
        }));
        switch (userSelection)
        {
            case CreateStudent:
                // CreateStudent();
                break;
            case ViewStudent:
                // ViewStudent();
                break;
            case UpdateStudent:
                // UpdateStudent();
                break;
            case DeleteStudent:
                // DeleteStudent();
                break;
            case Back:
                Admin_Menu();
                //YA TAN
                break;
            case Exit:
                Environment.Exit(0);
                break;
        }
    }

    public const string CreateClassroom = "Create Classroom", ViewClassroom = "View Classroom",
    UpdateClassroom = "Update Classroom", DeleteClassroom = "Delete Classroom";
    public static void Classroom_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(6)
                .AddChoices(new[] {
                    CreateClassroom, ViewClassroom, UpdateClassroom, DeleteClassroom, Back, Exit
        }));
        switch (userSelection)
        {
            case CreateClassroom:
                // CreateClassroom();
                break;
            case ViewClassroom:
                // ViewClassroom();
                break;
            case UpdateClassroom:
                // UpdateClassroom();
                break;
            case DeleteClassroom:
                // DeleteClassroom();
                break;
            case Back:
                Admin_Menu();
                //YA TAN
                break;
                //Back
            case Exit:
                Environment.Exit(0);
                break;
        }
    }

    public const string CreateGroup = "Create Group", ViewGroup = "View Group",
    UpdateGroup = "Update Group", DeleteGroup = "Delete Group";
    public static void Group_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(6)
                .AddChoices(new[] {
                    CreateGroup, ViewGroup, UpdateGroup, DeleteGroup, Back, Exit
        }));
        switch (userSelection)
        {
            case CreateGroup:
                // CreateGroup();
                break;
            case ViewGroup:
                // ViewGroup();
                break;
            case UpdateGroup:
                // UpdateGroup();
                break;
            case DeleteGroup:
                // DeleteGroup();
                break;
            case Back:
                Admin_Menu();
                break;
                //Back
            case Exit:
                Environment.Exit(0);
                break;
        }
    }

    public const string CreateSubject = "Create Subject", ViewSubject = "View Subject",
    UpdateSubject = "Update Subject", DeleteSubject = "Delete Subject";
    public static void Subject_Menu()
    {
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Select an option")
                .PageSize(6)
                .AddChoices(new[] {
                    CreateSubject, ViewSubject, UpdateSubject, DeleteSubject, Back, Exit
        }));
        switch (userSelection)
        {
            case CreateSubject:
                // CreateSubject();
                break;
            case ViewSubject:
                // ViewSubject();
                break;
            case UpdateSubject:
                // UpdateSubject();
                break;
            case DeleteSubject:
                // DeleteSubject();
                break;
            case Back:
                Admin_Menu();
                break;
                //Back
            case Exit:
                Environment.Exit(0);
                break;
        }
    }
}
