using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace Aula0
{

    public class Utils
    {
        Regex rgx;
        IList<double> doubleList;
        

        public Utils(string pattern)
        {
            rgx = new Regex(pattern);
            doubleList = new List<double>();
        }

        public static double StringToDouble(string valueToDouble)
        {

            double numberConverted;

            if (double.TryParse(valueToDouble, out numberConverted))
            {
                return numberConverted;
            }
            else
            {
                throw new InvalidCastException("Conversion to a Double is not supported.");
            }
        }

        public static double StringTInt(string valueToDouble)
        {

            int numberConvertedInt;

            if (int.TryParse(valueToDouble, out numberConvertedInt))
            {
                return numberConvertedInt;
            }
            else
            {
                throw new InvalidCastException("Conversion to a Int is not supported.");
            }
        }

        public IList<double> StringToListDouble(string sentence)
        {

            foreach (Match item in rgx.Matches(sentence))
            {
                doubleList.Add(StringToDouble(item.Value));
            }

           return doubleList;
        }
    }
}