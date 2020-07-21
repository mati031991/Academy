using System;

namespace StudentProject
{
    public class Subject : IInfo
    {
        private string _name = "";
        private string _direction = "";
        private string _speciality = "";
        private string _sesion = "";
        private int _amountHour = 0;

        public FinalRating FinalRating { get; set; }

        public Subject(string name, string direction, string speciality, string sesion, int amountHour)
        {
            this._name = name;
            this._direction = direction;
            this._speciality = speciality;
            this._sesion = sesion;
            this._amountHour = amountHour;
        }
        public Subject(Subject subject)
        {
            this._name = subject._name;
            this._direction = subject._direction;
            this._speciality = subject._speciality;
            this._sesion = subject._sesion;
            this._amountHour = subject._amountHour;
        }
        public string GetName()
        {
            return this._name;
        }
        public string GetDirection()
        {
            return this._direction;
        }
        public string GetSpeciality()
        {
            return this._speciality;
        }
        public string GetSesion()
        {
            return this._sesion;
        }
        public int GetAmountHour()
        {
            return this._amountHour;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Nazwa przedmiotu: {0} Kierunek: {1} Specjalność: {2} Semestr: {3} Ilość godzin: {4}", GetName(), GetDirection(), GetSpeciality(),GetSesion(),GetAmountHour()) ;
        }
    }
}
