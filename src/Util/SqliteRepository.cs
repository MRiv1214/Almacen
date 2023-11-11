using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Almacen.Models.AutoGen;

namespace src.Util;

public class SqliteRepository<T> : IRepository<T> where T : class
{
    private readonly AlmacenContext _context;
    private readonly DbSet<T> _dbSet;

    public SqliteRepository(AlmacenContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public void Create(T entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}