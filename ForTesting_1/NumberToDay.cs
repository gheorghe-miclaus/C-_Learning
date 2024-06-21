using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ns_NumberToDay
{
    public static class NumberToDay
    {
        private static List<string> _dayList = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
            "Saturday", "Sunday"};
        public static string Translate(int day)
        {
            if ( 1 <= day & day <= 7)
            {
                return _dayList[day - 1];
            }
            else
            {
                return "Invalid day of the week";
            }
        }


    }

    // for testing git
    public static class StringsTransformator
    {
        public static string TransformSeparators(  string input,  string originalSeparator, string targetSeparator) 
        {
                         
            return string.Join(targetSeparator,input.Split(originalSeparator));
        }
    }
}
