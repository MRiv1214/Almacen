using Almacen.Models.AutoGen;
using Almacen.Repository;
using Almacen.Models.Dtos;

namespace Almacen.Controllers;

public class StudentGroupController
{
    private readonly IRepository<StudentGroup>? studentGroupRepository;
    public StudentGroupController(IRepository<StudentGroup>? studentGroupRepository)
    {
        this.studentGroupRepository = studentGroupRepository;
    }
    public long CreateStudentGroup(StudentGroupDto studentGroupDto)
    {
        var studentGroup = new StudentGroup
        {
            Register = studentGroupDto.Register,
            GroupId = studentGroupDto.GroupId,
        };
        studentGroupRepository?.Create(studentGroup);
        return studentGroup.StudentGroupId;
    }
    public IEnumerable<StudentGroup> GetAllStudentGroups()
    {
        var studentGroups = studentGroupRepository?.GetAll();
        if (studentGroups == null)
        {
            return new List<StudentGroup>();
        }
        return studentGroups.Select(studentGroup => new StudentGroup
        {
            StudentGroupId = studentGroup.StudentGroupId,
            Register = studentGroup.Register,
            GroupId = studentGroup.GroupId,
        });
    }
    public StudentGroup GetStudentGroupById(long id)
    {
        var studentGroup = (studentGroupRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new StudentGroup
        {
            StudentGroupId = studentGroup.StudentGroupId,
            Register = studentGroup.Register,
            GroupId = studentGroup.GroupId,
        };
    }
    public void RemoveStudentGroup(long id)
    {
        var studentGroup = (studentGroupRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        studentGroupRepository?.Remove(studentGroup);
    }
    public void UpdateStudentGroup(StudentGroup studentGroup)
    {
        var studentGroupToUpdate = studentGroupRepository?.GetById(studentGroup.StudentGroupId)?? throw new ArgumentException("Invalid id");
        studentGroupToUpdate.Register = studentGroup.Register;
        studentGroupToUpdate.GroupId = studentGroup.GroupId;
        studentGroupRepository?.Update(studentGroupToUpdate);
    }

        
}
