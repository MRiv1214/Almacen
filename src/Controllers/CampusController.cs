using Almacen.Models.AutoGen;
using Almacen.Repository;
using Almacen.Models.Dtos;

namespace Almacen.Controllers;

public class CampusController
{
    private readonly IRepository<Campus>? campusRepository;
    public CampusController(IRepository<Campus>? campusRepository)
    {
        this.campusRepository = campusRepository;
    }
    public void CreateCampus(CampusDto campusDto)
    {
        var campus = new Campus
        {
            Name = campusDto.Name,
        };
        campusRepository?.Create(campus);
    }
    public IEnumerable<Campus> GetAllCampuses()
    {
        var campuses = campusRepository?.GetAll();
        if (campuses == null)
        {
            return new List<Campus>();
        }
        return campuses.Select(campus => new Campus
        {
            CampusId = campus.CampusId,
            Name = campus.Name,
        });
    }
    public Campus GetCampusById(long id)
    {
        var campus = (campusRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Campus
        {
            CampusId = campus.CampusId,
            Name = campus.Name,
        };
    }
    public void RemoveCampus(long id)
    {
        var campus = (campusRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        campusRepository?.Remove(campus);
    }
    public void UpdateCampus(Campus campus)
    {
        var campusToUpdate = campusRepository?.GetById(campus.CampusId ?? throw new ArgumentException("Invalid id"))?? throw new ArgumentException("Invalid id");
        campusToUpdate.Name = campus.Name;
        campusRepository?.Update(campusToUpdate);
    }
        
}
