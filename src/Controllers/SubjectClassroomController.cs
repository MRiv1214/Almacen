using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class SubjectClassroomController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    private readonly IRepository<SubjectClassroom>? subjectClassroomRepository;
    public SubjectClassroomController(IRepository<SubjectClassroom>? subjectClassroomRepository)
    {
        this.subjectClassroomRepository = subjectClassroomRepository;
    }
    public long CreateSubjectClassroom(SubjectClaasroomDto subjectClassroomDto)
    {
        var subjectClassroom = new SubjectClassroom
        {
            SubjectId = subjectClassroomDto.SubjectId,
            ClassroomId = subjectClassroomDto.ClassroomId,
        };
        subjectClassroomRepository?.Create(subjectClassroom);
        return subjectClassroom.SubClassId;
    }
    public IEnumerable<SubjectClassroom> GetAllSubjectClassrooms()
    {
        var subjectClassrooms = subjectClassroomRepository?.GetAll();
        if (subjectClassrooms == null)
        {
            return new List<SubjectClassroom>();
        }
        return subjectClassrooms.Select(subjectClassroom => new SubjectClassroom
        {
            SubClassId = subjectClassroom.SubClassId,
            SubjectId = subjectClassroom.SubjectId,
            ClassroomId = subjectClassroom.ClassroomId,
        });
    }
    public SubjectClassroom GetSubjectClassroomById(long id)
    {
        var subjectClassroom = (subjectClassroomRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new SubjectClassroom
        {
            SubClassId = subjectClassroom.SubClassId,
            SubjectId = subjectClassroom.SubjectId,
            ClassroomId = subjectClassroom.ClassroomId,
        };
    }
    public void RemoveSubjectClassroom(long id)
    {
        var subjectClassroom = (subjectClassroomRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        subjectClassroomRepository?.Remove(subjectClassroom);
    }
    public void UpdateSubjectClassroom(SubjectClassroom subjectClassroom)
    {
        var subjectClassroomToUpdate = subjectClassroomRepository?.GetById(subjectClassroom.SubClassId)?? throw new ArgumentException("Invalid id");
        subjectClassroomToUpdate.SubjectId = subjectClassroom.SubjectId;
        subjectClassroomToUpdate.ClassroomId = subjectClassroom.ClassroomId;
        subjectClassroomRepository?.Update(subjectClassroomToUpdate);
    }
    */
        
}
