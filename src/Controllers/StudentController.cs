using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;
public class StudentController
{
    private readonly IRepository<Student>? studentRepository;
    public StudentController(IRepository<Student>? studentRepository)
    {
        this.studentRepository = studentRepository;
    }
    public void CreateStudent(StudentDto studentDto)
    {
        var student = new Student
        {
            Register = studentDto.Register,
            UserId = studentDto.UserId,
            CareerId = studentDto.CareerId
        };
        studentRepository?.Create(student);
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
    public Student GetStudentById(long id)
    {
        var student = (studentRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Student
        {
            Register = student.Register,
            UserId = student.UserId,
            CareerId = student.CareerId
        };
    }
    public void RemoveStudent(long id)
    {
        var student = (studentRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        studentRepository?.Remove(student);
    }
    public void UpdateStudent(Student student)
    {
        var studentToUpdate = studentRepository?.GetById(student.UserId ?? throw new ArgumentException("Invalid id")) ?? throw new ArgumentException("Invalid id");
        studentToUpdate.Register = student.Register;
        studentToUpdate.CareerId = student.CareerId;
    }
    
}