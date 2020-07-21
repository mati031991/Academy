using System.Collections.Generic;

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
