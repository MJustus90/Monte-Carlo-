using System;

namespace Monte_Carlo__
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = iterations();

            var rand = new Random();

            int count = 0;

            for (int j = 0; j < i; j++)
            {
                (double, double) xy = makePairs(rand);

                // double r = hypotenuse(x , y);
                double r    = hypotenuseV2(xy);

                if (r <= 1) // I can call on hypotenuseV2 instead of defining r; same thing
                {
                    count++;
                }

            }

            double estPi = 4.0 * count / i;
            double diff = Math.Abs(Math.PI - estPi);

            Console.WriteLine(estPi);
            Console.WriteLine("Our estimate of by is off by: " + diff);
        }

        private static (double, double) makePairs(Random rand)
        {
            double x = rand.NextDouble();
            double y = rand.NextDouble();
            (double, double) xy = (x, y);
            return xy;
        }

        private static double hypotenuseV2((double, double) xy)
        {
            return Math.Sqrt(((xy.Item1) * (xy.Item1)) + ((xy.Item2) * (xy.Item2)));
        }

        private static int iterations()
        {
            Console.WriteLine("Choose 10, 100, 1000, or 10000 iterations");
            int i = Convert.ToInt32(Console.ReadLine());
            return i;
        }

        /* private static double hypotenuse(double x, double y)
         {
             double r = Math.Sqrt((x * x) + (y * y));

             return r;
         }
         */

        /* QUESTION
   *      1. Our program is only covering a quarter of the unit circle. Pi is defined using the whole unit circle, so we need to multiply by 4
   *      
   *      2. As the iterations increase, our approximation approaches the true value of Pi.
   *      
   *      3. It does not, because each time we are using randomly generated values
   *      
   *      4. Anything over 1,000,000,000 required more that 1 second of run time.
   *      
   *      5. At 10,000 iterations, our value is roughly +/- 0.001.
   *      
   *      6. Radiation shielding and neutron diffusion can be estimated using a monte carlo method (the origins of the name "Monte Carlo")
   */


    }
}
