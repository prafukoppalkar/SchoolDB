using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolDB.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int YearOfJoin { get; set; }

    }
//    public class StudentConfig : EntityTypeConfiguration<Student>
//    {
//        public StudentConfig()
//        {
//            HasKey(e => e.StudentId);
//        }
//    }
}
