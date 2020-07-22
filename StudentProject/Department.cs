using System.Collections.Generic;
using System.ComponentModel;
using System.IO.IsolatedStorage;

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
            Students.Add(student);
        }
        public bool AddLecturer(Lecturer lecturer, string departmentName)
        {
            bool result = true;

            new Lecturer(lecturer.GetForname(), lecturer.GetName(), lecturer.GetBirthdayDate(), lecturer.GetAcademicTitle(), lecturer.GetPosition());
            foreach (var item in Forces)
            {
                if (item.GetForceName() == departmentName)
                {
                    foreach (var lect in item.Lecturers)
                    {
                        if (lect.Equals(lecturer))
                        {
                            result = false;
                        }
                        else
                        {
                            item.AddLecturer(lecturer);
                            result = true;
                        }
                    }
                }
                else
                {
                    Force force = new Force(departmentName, null);
                    Forces.Add(force);
                    force.AddLecturer(lecturer);
                    result = true;
                }
            }
            return result;
        }
        public void StudentsInfo(bool infoRating)
        {
            if (infoRating)
            {
                foreach (var item in Students)
                {
                    item.Displayinfo();
                    System.Console.WriteLine(item.FinalRatings);
                }
            }
            else
            {
                foreach (var item in Students)
                {
                    item.Displayinfo();
                }
            }
        }
        public void ForcesInfo(bool infoLecturer)
        {
            foreach (var item in Forces)
            {
                if (infoLecturer)
                {
                    item.DisplayInfo();
                    System.Console.WriteLine(item.Lecturers);

                }
                else
                {
                    item.DisplayInfo();
                }

            }
        }
        public void InfoSubject()
        {
            foreach (var item in Subjects)
            {
                item.DisplayInfo();
            }
        }
        public bool AddRating(int nrIndex, string subjctName, int rating, string date)
        {
            return true;
        }
        public bool RemoveStudent(int nrIndex)
        {
            bool status = false;
            foreach (var item in Students)
            {
                if (item.GetIndex() == nrIndex)
                {
                    Students.Remove(item);
                    status = true;
                }
            }
            return status;
        }
        public bool BringingLecturer(Lecturer lecturer, string currentDepartment, string newDepartmant)
        {
            return true;
        }
    }
}
