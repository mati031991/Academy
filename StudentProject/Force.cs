using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    public class Force : IInfo
    {
        private string _name = "";
        private string _address = "";
        private List<Lecturer> lecturers;

        public Force(string name, string address)
        {
            _name = name;
            _address = address;
            lecturers = new List<Lecturer>();
        }
        public void AddLecturer(Lecturer lecturer)
        {
            lecturers.Add(lecturer);
        }
        public bool DeleteLecturer(Lecturer lecturer)
        {
            if (lecturers.Contains(lecturer))
            {
                lecturers.Remove(lecturer);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetForceName()
        {
            return _name;
        }
        public string GetForceAddress()
        {
            return _address;
        }
        public bool DeleteLecturer(string forname, string name)
        {
            Lecturer actLecturer = lecturers.Find(x => x.GetForname() == forname && x.GetName() == name);
            if (actLecturer != null)
            {
                lecturers.Remove(actLecturer);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayInfoByLecturers()
        {
            Console.WriteLine("Lista wykładowców: ");
            foreach (var item in lecturers)
            {
                item.DisplayInfo();
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Nazwa jednostki : {0} , Adres jednostki: {1}", this.GetForceName(), this.GetForceAddress());
        }
    }
}
