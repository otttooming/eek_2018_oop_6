using System;
namespace eek_2018_oop_6
{
    class Fibonacci
    {
        public double this[int nr]
        {
            get
            {
                if (nr == 0)
                    return 0;
                else if (nr == 1)
                    return 1;
                else
                {
                    double Fn_2 = 0, Fn_1 = 1, Fn = 0;
                    for (int i = 2; i <= nr; i++)
                    {
                        Fn = Fn_2 + Fn_1;
                        Fn_2 = Fn_1;
                        Fn_1 = Fn;
                    }

                    return Fn;
                }
            }
        }
    }
}