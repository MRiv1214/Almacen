using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;
public class StudentController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    private readonly IRepository<Student>? studentRepository;
    public StudentController(IRepository<Student>? studentRepository)
    {
        this.studentRepository = studentRepository;
    }
    public byte[] CreateStudent(StudentDto studentDto)
    {
        var student = new Student
        {
            Register = studentDto.Register,
            UserId = studentDto.UserId,
            CareerId = studentDto.CareerId
        };
        studentRepository?.Create(student);
        return student.Register;
    }
    public IEnumerable<Student> GetAllStudents()
    {
        var students = studentRepository?.GetAll();
        if (students == null)
        {
            return new List<Student>();
        }
        return students.Select(student => new Student
        {
            Register = student.Register,
            UserId = student.UserId,
            CareerId = student.CareerId
        });
    }
    public Student? GetStudentByRegister(byte[] register)
    {
        var student = studentRepository?.GetSingleBy(student => student.Register == register);
        if (student == null)
        {
            return null;
        }
        return new Student
        {
            Register = student.Register,
            UserId = student.UserId,
            CareerId = student.CareerId
        };
    }

    public Student? GetStudentById(long id)
    {
        var student = (studentRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        if (student == null)
        {
            return null;
        }
        return new Student
        {
            Register = student.Register,
            UserId = student.UserId,
            CareerId = student.CareerId
        };
    }
    public Student? GetStudentByUserId(long id)
    {
        var student = studentRepository?.GetSingleBy(x => x.UserId == id);
        if (student == null)
        {
            return null;
        }
        return new Student
        {
            Register = student.Register,
            UserId = student.UserId,
            CareerId = student.CareerId
        };
    }
    public void RemoveStudent(byte[] id)
    {
        var student = (studentRepository?.GetById(BitConverter.ToInt32(id, 0))) ?? throw new ArgumentException("Invalid id");
        studentRepository?.Remove(student);
    }
    public void UpdateStudent(Student student)
    {
        var studentToUpdate = studentRepository?.GetById(student.UserId ?? throw new ArgumentException("Invalid id")) ?? throw new ArgumentException("Invalid id");
        studentToUpdate.Register = student.Register;
        studentToUpdate.CareerId = student.CareerId;
        studentRepository?.Update(studentToUpdate);
    }
    */

}