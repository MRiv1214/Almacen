using Almacen.Models.AutoGen;
using Almacen.Models.Dtos;
using Almacen.Repository;
namespace Almacen.Controllers;

public class CareerController
{
    AlmacenContext db = AlmacenContext.GetInstance();
    /*
    public long CreateCareer(CareerDto careerDto)
    {
        var career = new Career
        {
            Name = careerDto.Name,
        };
        careerRepository?.Create(career);
        return career.CareerId;
    }
    public IEnumerable<Career> GetAllCareers()
    {
        var careers = careerRepository?.GetAll();
        if (careers == null)
        {
            return new List<Career>();
        }
        return careers.Select(career => new Career
        {
            CareerId = career.CareerId,
            Name = career.Name,
        });
    }
    public Career GetCareerById(long id)
    {
        var career = (careerRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Career
        {
            CareerId = career.CareerId,
            Name = career.Name,
        };
    }

    public Career GetCareerByName(string name)
    {
        var career = (careerRepository?.GetSingleBy(career => career.Name == name)) ?? throw new ArgumentException("Invalid name");
        return new Career
        {
            CareerId = career.CareerId,
            Name = career.Name,
        };
    }
    
    public void RemoveCareer(long id)
    {
        var career = (careerRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        careerRepository?.Remove(career);
    }
    public void UpdateCareer(Career career)
    {
        var careerToUpdate = careerRepository?.GetById(career.CareerId)?? throw new ArgumentException("Invalid id");
        careerToUpdate.Name = career.Name;
        careerRepository?.Update(careerToUpdate);
    }
    */
}