using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Конструирование_ПО
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DbConnection")
        {
        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Class_type> Class_type { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Field_of_study> Field_of_study { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Plan_discipline> Plan_discipline { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class_type>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Class_type>()
                .HasMany(e => e.Class)
                .WithOptional(e => e.Class_type)
                .HasForeignKey(e => e.ID_Class_type);

            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Plan)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.ID_Department);

            modelBuilder.Entity<Discipline>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Discipline>()
                .HasMany(e => e.Plan_discipline)
                .WithOptional(e => e.Discipline)
                .HasForeignKey(e => e.ID_Discipline);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.Abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Department)
                .WithOptional(e => e.Faculty)
                .HasForeignKey(e => e.ID_Faculty);

            modelBuilder.Entity<Field_of_study>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Field_of_study>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Field_of_study>()
                .HasMany(e => e.Plan)
                .WithOptional(e => e.Field_of_study)
                .HasForeignKey(e => e.ID_Field_of_study);

            modelBuilder.Entity<Plan>()
                .Property(e => e.Specialty)
                .IsUnicode(false);

            modelBuilder.Entity<Plan>()
                .Property(e => e.Form)
                .IsUnicode(false);

            modelBuilder.Entity<Plan>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<Plan>()
                .HasMany(e => e.Plan_discipline)
                .WithOptional(e => e.Plan)
                .HasForeignKey(e => e.ID_Plan);

            modelBuilder.Entity<Plan_discipline>()
                .Property(e => e.Exam_type)
                .IsUnicode(false);

            modelBuilder.Entity<Plan_discipline>()
                .HasMany(e => e.Class)
                .WithOptional(e => e.Plan_discipline)
                .HasForeignKey(e => e.ID_Plan_discipline);
        }
    }
}
