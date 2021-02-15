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
    //Restritions: none
    class Program
    {
        //Method: Main
        //Purpose: Create an array of x,y and z calculations
        //Restrictions: I don't think it works properly, I used a two dimensional array
        static void Main(string[] args)
        {
            //declare and initialize variables
            double x = -1;
            double y = 1;
            double z = 0;
           
            //create array to store doubles
            double[,] funcVal = new double[30,3];
            //increments x value in array
            int xcntr = 0;
            //for valid range of x
            for (x = -1; x<=1; x += 0.1)
            {

                //assign x to array
                funcVal[xcntr,0] = x;
                //increment xcntr
                xcntr++;

            }

            //for valid range of y
            for (y = 1; y <= 4; y += 0.1)
            {
                //reset x value incrementor
                xcntr = 0;
                //assign y to array
                funcVal[xcntr, 1] = y;
                
                //calculate z
                z = Math.Pow((3 * y), 2) + ((2 * x) - 1);
                //assign z to array
                funcVal[xcntr, 2] = z;
                //increment xcntr
                xcntr++;
            }

        }
    }
}
