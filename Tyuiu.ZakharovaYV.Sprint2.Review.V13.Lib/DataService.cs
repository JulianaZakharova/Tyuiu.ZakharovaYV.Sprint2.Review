using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tyuiu.ZakharovaYV.Sprint2.Review.V13.Lib
{
    public class DataService
    {
            public bool CheckDotInShadedArea(double x, double y)
            {
                bool res;
                if ((x * x + y * y <= 1) && ((x > 0 && x <= 1 && y > 0 && y <= 1) || ((y <= 1) && (y >= x - 1))))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                return res;
            }

        
    }

   


}