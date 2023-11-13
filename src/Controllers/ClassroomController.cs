using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class ClassroomController
{
    private readonly IRepository<ClassRoom>? classroomRepository;
    public ClassroomController(IRepository<ClassRoom>? classroomRepository)
    {
        this.classroomRepository = classroomRepository;
    }
    public long CreateClassroom(ClassroomDto classroomDto)
    {
        var classroom = new ClassRoom
        {
            Name = classroomDto.Name,
        };
        classroomRepository?.Create(classroom);
        return classroom.ClassroomId;
    }
    public IEnumerable<ClassRoom> GetAllClassrooms()
    {
        var classrooms = classroomRepository?.GetAll();
        if (classrooms == null)
        {
            return new List<ClassRoom>();
        }
        return classrooms.Select(classroom => new ClassRoom
        {
            ClassroomId = classroom.ClassroomId,
            Name = classroom.Name,
        });
    }
    public ClassRoom GetClassroomById(long id)
    {
        var classroom = (classroomRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new ClassRoom
        {
            ClassroomId = classroom.ClassroomId,
            Name = classroom.Name,
        };
    }
    public void RemoveClassroom(long id)
    {
        var classroom = (classroomRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        classroomRepository?.Remove(classroom);
    }
    public void UpdateClassroom(ClassRoom classroom)
    {
        var classroomToUpdate = classroomRepository?.GetById(classroom.ClassroomId)?? throw new ArgumentException("Invalid id");
        classroomToUpdate.Name = classroom.Name;
        classroomRepository?.Update(classroomToUpdate);
    }
}
