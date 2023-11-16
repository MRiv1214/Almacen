using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class StudentSubjectController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    private readonly IRepository<StudentSubject>? studentSubjectRepository;
    public StudentSubjectController(IRepository<StudentSubject>? studentSubjectRepository)
    {
        this.studentSubjectRepository = studentSubjectRepository;
    }
    public long CreateStudentSubject(StudentSubjectDto studentSubjectDto)
    {
        var studentSubject = new StudentSubject
        {
            Register = studentSubjectDto.Register,
            SubjectId = studentSubjectDto.SubjectId,
        };
        studentSubjectRepository?.Create(studentSubject);
        return studentSubject.StudentSubId;
    }
    public IEnumerable<StudentSubject> GetAllStudentSubjects()
    {
        var studentSubjects = studentSubjectRepository?.GetAll();
        if (studentSubjects == null)
        {
            return new List<StudentSubject>();
        }
        return studentSubjects.Select(studentSubject => new StudentSubject
        {
            StudentSubId = studentSubject.StudentSubId,
            Register = studentSubject.Register,
            SubjectId = studentSubject.SubjectId,
        });
    }
    public StudentSubject GetStudentSubjectById(long id)
    {
        var studentSubject = (studentSubjectRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new StudentSubject
        {
            StudentSubId = studentSubject.StudentSubId,
            Register = studentSubject.Register,
            SubjectId = studentSubject.SubjectId,
        };
    }
    public void RemoveStudentSubject(long id)
    {
        var studentSubject = (studentSubjectRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        studentSubjectRepository?.Remove(studentSubject);
    }
    public void UpdateStudentSubject(StudentSubject studentSubject)
    {
        var studentSubjectToUpdate = studentSubjectRepository?.GetById(studentSubject.StudentSubId) ?? throw new ArgumentException("Invalid id");
        studentSubjectToUpdate.Register = studentSubject.Register;
        studentSubjectToUpdate.SubjectId = studentSubject.SubjectId;
        studentSubjectRepository?.Update(studentSubjectToUpdate);
    }
    */
}