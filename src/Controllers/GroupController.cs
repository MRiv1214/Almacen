using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class GroupController
{
    private readonly IRepository<Group>? groupRepository;
    public GroupController(IRepository<Group>? groupRepository)
    {
        this.groupRepository = groupRepository;
    }
    public long CreateGroup(GroupDto groupDto)
    {
        var group = new Group
        {
            Name = groupDto.Name,
        };
        groupRepository?.Create(group);
        return group.GroupId;
    }
    public IEnumerable<Group> GetAllGroups()
    {
        var groups = groupRepository?.GetAll();
        if (groups == null)
        {
            return new List<Group>();
        }
        return groups.Select(group => new Group
        {
            GroupId = group.GroupId,
            Name = group.Name,
        });
    }
    public Group GetGroupById(long id)
    {
        var group = (groupRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Group
        {
            GroupId = group.GroupId,
            Name = group.Name,
        };
    }
    public void RemoveGroup(long id)
    {
        var group = (groupRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        groupRepository?.Remove(group);
    }
    public void UpdateGroup(Group group)
    {
        var groupToUpdate = groupRepository?.GetById(group.GroupId)?? throw new ArgumentException("Invalid id");
        groupToUpdate.Name = group.Name;
        groupRepository?.Update(groupToUpdate);
    }
        
}
