using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class SubjectController
{
    private readonly IRepository<Subject>? subjectRepository;
    public SubjectController(IRepository<Subject>? subjectRepository)
    {
        this.subjectRepository = subjectRepository;
    }
    public void CreateSubject(SubjectDto subjectDto)
    {
        var subject = new Subject
        {
            Name = subjectDto.Name,
        };
        subjectRepository?.Create(subject);
    }
    public IEnumerable<Subject> GetAllSubjects()
    {
        var subjects = subjectRepository?.GetAll();
        if (subjects == null)
        {
            return new List<Subject>();
        }
        return subjects.Select(subject => new Subject
        {
            SubjectId = subject.SubjectId,
            Name = subject.Name,
        });
    }
    public Subject GetSubjectById(long id)
    {
        var subject = (subjectRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Subject
        {
            SubjectId = subject.SubjectId,
            Name = subject.Name,
        };
    }
    public void RemoveSubject(long id)
    {
        var subject = (subjectRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        subjectRepository?.Remove(subject);
    }
    public void UpdateSubject(Subject subject)
    {
        var subjectToUpdate = subjectRepository?.GetById(subject.SubjectId ?? throw new ArgumentException("Invalid id"))?? throw new ArgumentException("Invalid id");
        subjectToUpdate.Name = subject.Name;
        subjectRepository?.Update(subjectToUpdate);
    }

}
