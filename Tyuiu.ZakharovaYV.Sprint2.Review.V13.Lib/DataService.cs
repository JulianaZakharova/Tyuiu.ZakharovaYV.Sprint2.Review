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
                if ((y>=x * x-2) && ((y<=-x)||(y <= x)))
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