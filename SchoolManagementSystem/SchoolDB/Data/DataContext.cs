using SchoolDB.Data.Entities;
using SchoolDB.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(): base("SchoolDb")
        {

        }
        protected override void OnModelCreating(DbModelBuilder Builder)
        {
            Builder.Configurations.Add(new StudentClassConfig());
            Builder.Configurations.Add(new ClassroomConfig());
        }

        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

    }
}
