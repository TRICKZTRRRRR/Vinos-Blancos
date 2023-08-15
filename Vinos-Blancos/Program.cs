using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos_Blancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] wineSalesData = {
                175134, 175388, 172818 + 35432, 142709, 151437,
                152620, 150979, 152210, 149450, 154398, 150160
            };

            Array.Sort(wineSalesData);
            Array.Reverse(wineSalesData);

            DisplaySalesDataAndGraph(wineSalesData);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void DisplaySalesDataAndGraph(int[] wineSales)
        {
            const int maxStar = 100;

            int maxValue = FindMaxValue(wineSales);

            double scaleFactor = (double)maxStar / maxValue;

            for (int i = 0; i < wineSales.Length; i++)
            {
                int stars = CalculateStars(wineSales[i], scaleFactor);
                ShowDataAndGraph(2009 + i, wineSales[i], stars);
            }
        }

        static int FindMaxValue(int[] array)
        {
            int maxValue = 0;
            foreach (int value in array)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
            return maxValue;
        }

        static int CalculateStars(int value, double scaleFactor)
        {
            return (int)(scaleFactor * value);
        }

        static void ShowDataAndGraph(int year, int sales, int stars)
        {
            Console.WriteLine($"Year {year}: Sales: {sales,7} liters  Graph: {new string('*', stars)}");
        }
    }
}
