using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Almacen.Models.AutoGen;

namespace Almacen.Models;

public class Teacher
{
    //Employee
    public required Employee Employee { get; set; }
    //User
    public required User User { get; set; }
}