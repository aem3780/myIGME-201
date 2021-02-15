using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_5
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: PE8
    //Restritions:
    class Program
    {
        //Method: Main
        //Purpose:
        //Restrictions:
        static void Main(string[] args)
        {
            /*Given the formula z = 3y2 + 2x - 1 write a console application to 
             * calculate z for the following ranges of x and y:
            -1 <= x <= 1 in 0.1 increments
            1 <= y <= 4 in 0.1 increments

           Use a 3 - dimensional array double[,,] to store the values of x, y and z for each computation. */

            
            double x = -1;
            double y = 1;
            double z = 0;
            double num1 = 0;
            double num2 = 0;
            double[,] funcVal = new double[40,3];
            int xcntr = 0;
            for (x = -1; x<=1; x += 0.1)
            {
                funcVal[xcntr,0] = x;
                num1 = ((2*x) - 1);
                Console.Write("x:"+funcVal[xcntr, 0]);
                xcntr++;

                for (y = 1; y <= 4; y += 0.1)
                {
                    
                    funcVal[xcntr, 1] = y;
                    num2 = Math.Pow((3 * y), 2);

                    z = num1 + num2;

                    funcVal[xcntr, 2] = z;
                    Console.Write("y:"+funcVal[xcntr, 1]);
                    xcntr++;
                }

            }
            



        }
    }
}
