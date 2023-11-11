using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Almacen.Models.AutoGen;

public partial class AlmacenContext : DbContext
{
    public AlmacenContext()
    {
    }

    public AlmacenContext(DbContextOptions<AlmacenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Campus> Campuses { get; set; }

    public virtual DbSet<Career> Careers { get; set; }

    public virtual DbSet<ClassRoom> ClassRooms { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeGroup> EmployeeGroups { get; set; }

    public virtual DbSet<EmployeeSubject> EmployeeSubjects { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Maintenance> Maintenances { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MultipleSesRequest> MultipleSesRequests { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<SingleSesRequest> SingleSesRequests { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentGroup> StudentGroups { get; set; }

    public virtual DbSet<StudentSubject> StudentSubjects { get; set; }

    public virtual DbSet<StudentsRequest> StudentsRequests { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubjectClassroom> SubjectClassrooms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Data/Almacen.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Campus>(entity =>
        {
            entity.ToTable("campus");

            entity.Property(e => e.CampusId).HasColumnName("campusId");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Career>(entity =>
        {
            entity.ToTable("career");

            entity.Property(e => e.CareerId).HasColumnName("careerId");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<ClassRoom>(entity =>
        {
            entity.ToTable("classRooms");

            entity.Property(e => e.ClassroomId).HasColumnName("classroomId");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Payroll);

            entity.ToTable("employees");

            entity.Property(e => e.Payroll).HasColumnName("payroll");
            entity.Property(e => e.CareerId).HasColumnName("careerId");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.UserType).HasColumnName("userType");

            entity.HasOne(d => d.Career).WithMany(p => p.Employees).HasForeignKey(d => d.CareerId);

            entity.HasOne(d => d.User).WithMany(p => p.Employees).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<EmployeeGroup>(entity =>
        {
            entity.ToTable("employeeGroup");

            entity.Property(e => e.EmployeeGroupId).HasColumnName("employeeGroupId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.Payroll).HasColumnName("payroll");

            entity.HasOne(d => d.Group).WithMany(p => p.EmployeeGroups).HasForeignKey(d => d.GroupId);
        });

        modelBuilder.Entity<EmployeeSubject>(entity =>
        {
            entity.HasKey(e => e.EmployeeSubId);

            entity.ToTable("employeeSubject");

            entity.Property(e => e.EmployeeSubId).HasColumnName("employeeSubId");
            entity.Property(e => e.Payroll).HasColumnName("payroll");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");

            entity.HasOne(d => d.PayrollNavigation).WithMany(p => p.EmployeeSubjects).HasForeignKey(d => d.Payroll);

            entity.HasOne(d => d.Subject).WithMany(p => p.EmployeeSubjects).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("groups");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Maintenance>(entity =>
        {
            entity.ToTable("maintenances");

            entity.Property(e => e.MaintenanceId).HasColumnName("maintenanceId");
            entity.Property(e => e.CareerId).HasColumnName("careerId");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Desc).HasColumnName("desc");
            entity.Property(e => e.MaintType).HasColumnName("maintType");
            entity.Property(e => e.MaterialId).HasColumnName("materialId");
            entity.Property(e => e.ScheduleDate).HasColumnName("scheduleDate");
            entity.Property(e => e.SpareParts).HasColumnName("spareParts");

            entity.HasOne(d => d.Career).WithMany(p => p.Maintenances).HasForeignKey(d => d.CareerId);

            entity.HasOne(d => d.Material).WithMany(p => p.Maintenances).HasForeignKey(d => d.MaterialId);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.ToTable("materials");

            entity.Property(e => e.MaterialId).HasColumnName("materialId");
            entity.Property(e => e.Desc).HasColumnName("desc");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MultipleSesRequest>(entity =>
        {
            entity.HasKey(e => e.MulSesRequestId);

            entity.ToTable("multipleSesRequest");

            entity.Property(e => e.MulSesRequestId).HasColumnName("mulSesRequestId");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.EndDate).HasColumnName("endDate");
            entity.Property(e => e.Payroll).HasColumnName("payroll");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.RequestId).HasColumnName("requestId");

            entity.HasOne(d => d.PayrollNavigation).WithMany(p => p.MultipleSesRequests).HasForeignKey(d => d.Payroll);

            entity.HasOne(d => d.Request).WithMany(p => p.MultipleSesRequests).HasForeignKey(d => d.RequestId);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.ToTable("requests");

            entity.Property(e => e.RequestId).HasColumnName("requestId");
            entity.Property(e => e.AuthSignature).HasColumnName("authSignature");
            entity.Property(e => e.CampusId).HasColumnName("campusId");
            entity.Property(e => e.CareerId).HasColumnName("careerId");
            entity.Property(e => e.ClassroomId).HasColumnName("classroomId");
            entity.Property(e => e.ControlNum)
                .HasColumnType("NUMERIC")
                .HasColumnName("controlNum");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DeliveryTime).HasColumnName("deliveryTime");
            entity.Property(e => e.DepartureTime).HasColumnName("departureTime");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.MatAmount)
                .HasColumnType("NUMERIC")
                .HasColumnName("matAmount");
            entity.Property(e => e.MaterialId).HasColumnName("materialId");
            entity.Property(e => e.Payroll).HasColumnName("payroll");

            entity.HasOne(d => d.Campus).WithMany(p => p.Requests).HasForeignKey(d => d.CampusId);

            entity.HasOne(d => d.Career).WithMany(p => p.Requests).HasForeignKey(d => d.CareerId);

            entity.HasOne(d => d.Classroom).WithMany(p => p.Requests).HasForeignKey(d => d.ClassroomId);

            entity.HasOne(d => d.Group).WithMany(p => p.Requests).HasForeignKey(d => d.GroupId);

            entity.HasOne(d => d.Material).WithMany(p => p.Requests).HasForeignKey(d => d.MaterialId);

            entity.HasOne(d => d.PayrollNavigation).WithMany(p => p.Requests).HasForeignKey(d => d.Payroll);
        });

        modelBuilder.Entity<SingleSesRequest>(entity =>
        {
            entity.HasKey(e => e.SinSesReqId);

            entity.ToTable("singleSesRequest");

            entity.Property(e => e.SinSesReqId).HasColumnName("sinSesReqId");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Payroll).HasColumnName("payroll");
            entity.Property(e => e.Period).HasColumnName("period");
            entity.Property(e => e.RequestId).HasColumnName("requestId");

            entity.HasOne(d => d.PayrollNavigation).WithMany(p => p.SingleSesRequests).HasForeignKey(d => d.Payroll);

            entity.HasOne(d => d.Request).WithMany(p => p.SingleSesRequests).HasForeignKey(d => d.RequestId);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Register);

            entity.ToTable("students");

            entity.Property(e => e.Register)
                .HasColumnType("NUMERIC")
                .HasColumnName("register");
            entity.Property(e => e.CareerId).HasColumnName("careerId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Career).WithMany(p => p.Students).HasForeignKey(d => d.CareerId);

            entity.HasOne(d => d.User).WithMany(p => p.Students).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<StudentGroup>(entity =>
        {
            entity.ToTable("studentGroup");

            entity.Property(e => e.StudentGroupId).HasColumnName("studentGroupId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.Register)
                .HasColumnType("NUMERIC")
                .HasColumnName("register");

            entity.HasOne(d => d.Group).WithMany(p => p.StudentGroups).HasForeignKey(d => d.GroupId);

            entity.HasOne(d => d.RegisterNavigation).WithMany(p => p.StudentGroups).HasForeignKey(d => d.Register);
        });

        modelBuilder.Entity<StudentSubject>(entity =>
        {
            entity.HasKey(e => e.StudentSubId);

            entity.ToTable("studentSubject");

            entity.Property(e => e.StudentSubId).HasColumnName("studentSubId");
            entity.Property(e => e.Register)
                .HasColumnType("NUMERIC")
                .HasColumnName("register");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");

            entity.HasOne(d => d.RegisterNavigation).WithMany(p => p.StudentSubjects).HasForeignKey(d => d.Register);

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentSubjects).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<StudentsRequest>(entity =>
        {
            entity.ToTable("studentsRequest");

            entity.Property(e => e.StudentsRequestId).HasColumnName("studentsRequestId");
            entity.Property(e => e.Register)
                .HasColumnType("NUMERIC")
                .HasColumnName("register");
            entity.Property(e => e.RequestId).HasColumnName("requestId");

            entity.HasOne(d => d.RegisterNavigation).WithMany(p => p.StudentsRequests).HasForeignKey(d => d.Register);

            entity.HasOne(d => d.Request).WithMany(p => p.StudentsRequests).HasForeignKey(d => d.RequestId);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.ToTable("subject");

            entity.Property(e => e.SubjectId).HasColumnName("subjectId");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<SubjectClassroom>(entity =>
        {
            entity.HasKey(e => e.SubClassId);

            entity.ToTable("SubjectClassroom");

            entity.Property(e => e.ClassroomId).HasColumnName("classroomId");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");

            entity.HasOne(d => d.Classroom).WithMany(p => p.SubjectClassrooms).HasForeignKey(d => d.ClassroomId);

            entity.HasOne(d => d.Subject).WithMany(p => p.SubjectClassrooms).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.LastName).HasColumnName("lastName");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
