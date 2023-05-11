using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTest14
{
    public class MyMath
    {
        public static double Summ(string num1, string num2)
        {
            double summ;

            Double.TryParse(num1, out double n1);
            Double.TryParse(num1, out double n2);
            summ = n1 + n2;
            return summ;
        }
    }
    //

}
