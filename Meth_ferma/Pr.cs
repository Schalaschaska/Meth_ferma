using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meth_ferma
{
    class Pr
    {
        public double S, y, sqr_S, k = 1, pr_rez, mn, mn2, K;
        public bool flag = true;
        public double Z(int N)
        {
            while (flag != false)
            {
                S = Math.Ceiling(Math.Sqrt(N));
                y = Math.Pow((S + k), 2) - N;
                sqr_S = Math.Sqrt(y);
                k++;


                if (sqr_S % 1 == 0)
                {

                    pr_rez = Math.Pow((S + k - 1), 2) - (sqr_S * sqr_S);
                    flag = false;

                    mn = (S + (k - 1) + sqr_S);
                    mn2 = (S + (k - 1) - sqr_S);
                }
               
            }
           
            return mn;

        }
        public double Z2(int N)
        {
            while (flag != false)
            {
                S = Math.Ceiling(Math.Sqrt(N));
                y = Math.Pow((S + k), 2) - N;
                sqr_S = Math.Sqrt(y);
                k++;

                if (sqr_S % 1 == 0)
                {
                    pr_rez = Math.Pow((S + k - 1), 2) - (sqr_S * sqr_S);
                    flag = false;

                    mn = (S + (k - 1) + sqr_S);
                    mn2 = (S + (k - 1) - sqr_S);
                }
                
            }
            return mn2;

        }

      
       
    }
    
}
