using SchoolDB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDB
{
    public partial class Form1 : Form
    {
        DataContext ctx;
        public Form1()
        {
            InitializeComponent();
            //SetupData();
            ctx = new DataContext();
        }
        //private void SetupData()
        //{
        //    try
        //    {
        //        using (var ctx = new DataContext())
        //        {
        //            var student = ctx.Students.FirstOrDefault();
        //            MessageBox.Show("Done");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void Btn_displayStudentsInClassroom1_Click(object sender, EventArgs e)
        {
            var studs = ctx.StudentClasses.Where(s => s.ClassroomId.Equals(1)).Select(s=> new { s.StudentId, s.Student.Fname,s.Student.Lname,s.Student.DateOfBirth});
            dataGridView1.DataSource = studs.ToList();
        }

        private void btn_ClassrroomDetails_Click(object sender, EventArgs e)
        {
            var details = ctx.Classrooms.Select(t => new { t.Id, t.Teacher.Subject, t.TeacherId, t.Teacher.Fname }).OrderBy(t=>t.Id);
            dataGridView1.DataSource = details.ToList();
        }

        private void Btn_DOBQuery_Click(object sender, EventArgs e)
        {
            DateTime x = Convert.ToDateTime("08-08-1999");
            DateTime y = Convert.ToDateTime("10-10-2010");

            var StudsDob = ctx.Students.Where(ex => ex.DateOfBirth > x && ex.DateOfBirth < y).Select(ex => new { ex.Id, ex.Fname,ex.Lname, ex.DateOfBirth });
            dataGridView1.DataSource = StudsDob.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
