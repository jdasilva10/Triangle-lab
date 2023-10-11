using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoystonLastLab
{
    public class Triangle
    {
        public string ValidTriangle(int firstAngle, int secondAngle, int
    thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The Triangle is Valid.";
            }
            else
            {
                result = "The Triangle is not Valid.";
            }

            return result;
        }
    }
}
