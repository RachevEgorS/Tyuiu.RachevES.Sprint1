using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RachevES.Sprint1.Task4.V30.Lib
{
    public class DataService : ISprint1Task4V30
    {
        public double Calculate(double x, double y)
        {
            double e = 2.718;
            var res = ((x + Math.Pow(y, 3)) / (Math.Pow(e, 2 - y)));
            return Math.Round(res,3);
        }
    }
}
