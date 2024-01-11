using RainbowSchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolLib
{
    public class Management
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private List<subject> subject = new List<subject>();

        public List<Student> Students
        {
            get { return students; }
            private set { students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            private set { teachers = value; }
        }

        public List<subject> Subjects
        {
            get { return subject; }
            private set { subject = value; }
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddSubject(subject subject)
        {
            this.subject.Add(subject);
        }
    }
}