using System;
using System.Collections.Generic;
using System.Text;
using StudentProject;

namespace StudentProject
{
    public class Person : IInfo
    {
        protected string _forName { get; set; } = "";
        protected string _name { get; set; } = "";
        protected string _birthdayDate { get; set; } = "";

        public Person()
        {

        }
        public Person(string forname, string name, string birthdaydate)
        {
            this._forName = forname;
            this._name = name;
            this._birthdayDate = birthdaydate;
        }
        public string GetForname()
        {
            return _forName;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetBirthdayDate()
        {
            return _birthdayDate;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Imię: {0} Nazwisko: {1} Data urodzin: {2}", _forName, _name, _birthdayDate);
        }
    }
}
