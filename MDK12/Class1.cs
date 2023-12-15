using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MDK12
{
    public class Class1
    {
        public void Par(int a, int b, int c, out int ar, out int vol)
        {
            int area = 2 * (a * b + b * c + a * c);           
            ar = area;
            int volume = a * b * c;
            vol = volume;
        }
        public void Calc(int a,out int sum, out int proiz )
        {
            int firstCount = a / 10;
            int secondCount = a % 10;

            int s = firstCount + secondCount;
            int p = firstCount * secondCount;

            sum= s; proiz = p;
            
        }
    }
}
