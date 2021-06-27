using SchoolDB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Data.Entity
{
    public class StudentClass
    {
       
        public int ClassroomId { get; set; }
        public int StudentId { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Student Student { get; set; }

    }
    public class StudentClassConfig : EntityTypeConfiguration<StudentClass>
    {
        public StudentClassConfig()
        {
            HasKey(e => new { e.ClassroomId, e.StudentId });
        }
    }
}
