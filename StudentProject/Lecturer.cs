using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    public class Lecturer : Person
    {
        private string _academicTitle = "";
        private string _position = "";

        public Lecturer()
        {

        }
        public Lecturer(string forname, string name, string birthDate, string academicTitle, string position)
        {
            this._academicTitle = academicTitle;
            this._position = position;
            base._forName = forname;
            base._name = name;
            base._birthdayDate = birthDate;
        }
        public new void DisplayInfo()
        {
            Console.WriteLine("Tytuł: {0} Stanowisko: {1}", this._academicTitle, this._position);
            base.DisplayInfo();
        }
    }
}
