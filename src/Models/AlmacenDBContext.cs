using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Almacen.Models.AutoGenModels;

namespace Almacen.Models;

public partial class AlmacenDBContext : DbContext
{
    public AlmacenDBContext()
    {
    }

    public AlmacenDBContext(DbContextOptions<AlmacenDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=Data/Almacen.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("employees");

            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.CareerId).HasColumnName("careerId");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserType).HasColumnName("userType");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("students");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("studentId");
            entity.Property(e => e.CarreerId).HasColumnName("carreerId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Students).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userId");
            entity.Property(e => e.LastName).HasColumnName("lastName");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
