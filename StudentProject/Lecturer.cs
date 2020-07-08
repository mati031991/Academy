using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    public class Lecturer
    {
        private string _academicTitle = "";
        private string _position = "";

        public Lecturer()
        {

        }
        public Lecturer(string academicTitle, string position)
        {
            this._academicTitle = academicTitle;
            this._position = position;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Tytuł: {0} Stanowisko: {1}", this._academicTitle, this._position);
        }
    }
}
