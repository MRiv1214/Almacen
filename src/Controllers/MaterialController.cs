using Almacen.Models.AutoGen;
using Almacen.Repository;
using Almacen.Models.Dtos;

namespace Almacen.Controllers;

public class MaterialController
{
    private readonly IRepository<Material>? materialRepository;
    public MaterialController(IRepository<Material>? materialRepository)
    {
        this.materialRepository = materialRepository;
    }
    public long CreateMaterial(MaterialDto materialDto)
    {
        var material = new Material
        {
            Name = materialDto.Name,
            Desc = materialDto.Desc,
        };
        materialRepository?.Create(material);
        return material.MaterialId;
    }
    public IEnumerable<Material> GetAllMaterials()
    {
        var materials = materialRepository?.GetAll();
        if (materials == null)
        {
            return new List<Material>();
        }
        return materials.Select(material => new Material
        {
            MaterialId = material.MaterialId,
            Name = material.Name,
            Desc = material.Desc,
        });
    }
    public Material GetMaterialById(long id)
    {
        var material = (materialRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        return new Material
        {
            MaterialId = material.MaterialId,
            Name = material.Name,
            Desc = material.Desc,
        };
    }
    public void RemoveMaterial(long id)
    {
        var material = (materialRepository?.GetById(id)) ?? throw new ArgumentException("Invalid id");
        materialRepository?.Remove(material);
    }
    public void UpdateMaterial(Material material)
    {
        var materialToUpdate = materialRepository?.GetById(material.MaterialId) ?? throw new ArgumentException("Invalid id");
        materialToUpdate.Name = material.Name;
        materialToUpdate.Desc = material.Desc;
        materialRepository?.Update(materialToUpdate);
    }
        
}