using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    public class FinalRating : IInfo
    {
        private double _valuation = 0.0;
        private string _date = "";

        public FinalRating(double valuation, string date, Subject subject)
        {
            _valuation = valuation;
            _date = date;

        }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
