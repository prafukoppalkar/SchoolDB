using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolDB.Data.Entity
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
    }
    //public class TeacherConfig : EntityTypeConfiguration<Teacher>
    //{
    //    public TeacherConfig()
    //    {
    //        HasKey(e => e.TeacherId);
    //    }
    //}
}
