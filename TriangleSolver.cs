using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{

    //TriangleSolver Class
    public class TriangleSolver
    {
        //Analyze Method for checking whether it forms a triangle or not
        public static string Analyze(int a, int b, int c)
        {
            //checking for equilateral triangle
            if (a == b && b == c)
            {
                return "It is an equilateral triangle";
            }
            else
            {
                //checking for Isosceles triangle
                if (a == b || b == c || a == c)
                {
                    return "It is an Isosceles triangle";
                }
                //checking for scalene and not a triangle
                else
                {
                    if (a>b && a>c)
                    {
                        if((b+c)>a)
                            return "It is a scalene triangle";
                        else
                            return "It is not a triangle";
                    }

                    else if (b > a && b > c)
                    {
                        if ((a + c) > b)
                            return "It is a scalene triangle";
                        else
                            return "It is not a triangle";
                    }

                    else if (c > a && c > b)
                    {
                        if ((b + a) > c)
                            return "It is a scalene triangle";
                        else
                            return "It is not a triangle";
                    }
                    return "It is not a triangle";


                }
            }
        }
    }
}
