using System;
using System.Collections.Generic;

namespace StudentProject
{
    public class Force : IInfo
    {
        private string _name = "";
        private string _address = "";
        public List<Lecturer> Lecturers { get; private set; }

        public Force(string name, string address)
        {
            _name = name;
            _address = address;
            Lecturers = new List<Lecturer>();
        }
        public void AddLecturer(Lecturer lecturer)
        {
            Lecturers.Add(lecturer);
        }
        public bool DeleteLecturer(Lecturer lecturer)
        {
            if (Lecturers.Contains(lecturer))
            {
                Lecturers.Remove(lecturer);
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
            Lecturer actLecturer = Lecturers.Find(x => x.GetForname() == forname && x.GetName() == name);
            if (actLecturer != null)
            {
                Lecturers.Remove(actLecturer);
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
            foreach (var item in Lecturers)
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
