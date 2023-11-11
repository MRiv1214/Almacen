using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen.Repository;

public interface IRepository<T> where T : class
{
    void Create(T entity);
    IEnumerable<T> GetAll();
    T GetById(int id);
    T GetById(long id);
    void Remove(T entity);
    void Update(T entity);
}