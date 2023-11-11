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
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id) ?? throw new ArgumentException("Invalid id");
    }
    public T GetById(long id)
    {
        return _dbSet.Find(id) ?? throw new ArgumentException("Invalid id");
    }
    public void Remove(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }
        _dbSet.Update(entity);
        _context.SaveChanges();
    }
}