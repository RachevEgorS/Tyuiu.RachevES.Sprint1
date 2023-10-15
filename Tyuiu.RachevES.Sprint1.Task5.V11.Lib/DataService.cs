using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RachevES.Sprint1.Task5.V11.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
         var res  = ( k / 100) % 10;
            return res;
        }
    }
}
