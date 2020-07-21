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
        public void DisplayInfo()
        {
            Console.WriteLine("Nazwa przedmiotu: {0} Kierunek: {1} Specjalność: {2} Semestr: {3} Ilość godzin: {4}");
        }
    }
}
