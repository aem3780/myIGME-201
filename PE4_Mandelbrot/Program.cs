using System;

namespace PE4_Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>
    

    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double newImagCoord;
            double newRealCoord;
            double imagCoordEnd;
            double realCoordEnd;
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            

            Console.WriteLine("Please enter a number greater than -1.2:");
            newImagCoord = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a number less than -1.2:");
            imagCoordEnd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a number less than 1.77:");
            newRealCoord = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a number greater than 1.77:");
            realCoordEnd = Convert.ToDouble(Console.ReadLine());

            double x = (newImagCoord / 48);
            double y = (newRealCoord / 80);
            for (imagCoord = newImagCoord; imagCoord >= imagCoordEnd; imagCoord -=x )
            {
                for (realCoord = newRealCoord; realCoord <= realCoordEnd; realCoord +=y)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}

