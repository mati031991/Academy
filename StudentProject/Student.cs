using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    public class Student : Person
    {
        private string _direction = "";
        private string _speciality = "";
        private int _year = 0;
        private int _group = 0;
        private int _index = 0;
        public List<FinalRating> FinalRatings { get; set; }

        public Student() : base()
        {

        }
        public Student(string forname, string name, string birthdaydate, string directory, string speciality, int year, int group, int index) : base(forname, name, birthdaydate)
        {
            this._direction = directory;
            this._speciality = speciality;
            this._year = year;
            this._group = group;
            this._index = index;
        }
        public string GetDirection()
        {
            return _direction;
        }
        public string GetSpeciality()
        {
            return _speciality;
        }
        public int GetYear()
        {
            return _year;
        }
        public int GetGroup()
        {
            return _group;
        }
        public int GetIndex()
        {
            return _index;
        }
        public void Displayinfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Kierunek: {0} Specjalność: {1} Rok: {2} Grupa: {3} Index: {4}", _direction, _speciality, _year, _group, _index);
        }
    }
}
