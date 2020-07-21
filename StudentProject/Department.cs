using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    public class Department
    {
        public List<Force> Forces { get; set; }
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }

        public Department()
        {
            Forces = new List<Force>();
            Subjects = new List<Subject>();
        }
        public void AddForce(string name, string address)
        {
            Forces.Add(new Force(name, address));
        }
        public void AddSubject(Subject subject)
        {
            Subjects.Add(new Subject(subject));
        }
        public void AddStudent(Student student)
        {

        }
        public bool AddLecturer(Lecturer lecturer, string departmentName)
        {
            return true;
        }
        public void StudentsInfo(bool infoRating)
        {

        }
        public void ForcesInfo(bool infoLecturer)
        {

        }
        public void InfoSubject()
        {

        }
        public bool AddRating(int nrIndex, string subjctName, int rating, string date)
        {
            return true;
        }
        public bool RemoveStudent(int nrIndex)
        {
            return true;
        }
        public bool BringingLecturer(Lecturer lecturer, string currentDepartment, string newDepartmant)
        {
            return true;
        }
    }
}
