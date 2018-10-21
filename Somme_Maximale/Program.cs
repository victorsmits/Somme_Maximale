using System;
using System.Collections.Generic;

namespace Somme_Maximale
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double[] temp = { 13.1, 10.7, 11.7, 12.4, 10.2, 8.1,
                10.5, 12.4, 9.9, 13.2 };
            Console.WriteLine(MaxMeanWindow(temp, 3));
        }
        /*
        * @pre temperatures != null
        * 0 < n <= temperatures . Length
        * @post The returned value contains the maximum mean computed
        * on all the possible windows of ’n’ consecutives values
        * in the ’temperatures ’ array
        */
        public static double MaxMeanWindow(double[] temp, int n)
        {
            Queue<double> mean = new Queue<double>();
            mean.Enqueue(0);
            try
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    double count = 0;
                    for (int x = 0; x < n; x++)
                    {
                        count += temp[i + x];
                        Console.Write("\n" + temp[i + x]);
                    }
                    double mean_value = count / n;
                    Console.Write("\n count = " + count);
                    Console.Write("\n mean = " + Math.Round(mean_value, 2));
                    Console.Write("\n------");
                    double last_mean = mean.Dequeue();
                    if (mean_value >= last_mean)
                    {
                        mean.Enqueue(mean_value);
                    }
                    else
                    {
                        mean.Enqueue(last_mean);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                double MaxMeanValue = mean.Dequeue();
                return Math.Round(MaxMeanValue, 2);
            }
            return 0;
        }
    }
}
