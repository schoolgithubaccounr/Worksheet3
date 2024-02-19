using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using static System.Console;

namespace Worksheet3Q1
{

    internal class Program
    {





        static void Main(string[] args)
        {


            int[] numbers = {7,3,6,2,9};

            int[] morenumbers = { 5, 2, 8, 9, 2 };

            //SortingMaxArray(numbers);

            //SortingMinArray(numbers);

            //AreSame(numbers, morenumbers);

            //ThirdElementAverage(numbers);

            //standDev(numbers);







        }//end of main method

        static void SortingMaxArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[1])
                {
                    numbers[1] = numbers[i]; 
                }

            }
            WriteLine($"The biggest number is {numbers[1]}");

        }//end of Sorting Max array

        static void SortingMinArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[1])
                {
                    numbers[1] = numbers[i];
                }

            }
            WriteLine($"The smallest number is {numbers[1]}");

        }//end of Sorting Min array

        static void AreSame(int[] numbers, int[] morenumbers)
        {
            bool same = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < morenumbers.Length; j++)
                {

                    if (numbers[i] == morenumbers[i])
                    {

                        same = true;

                    }

                }

            }

            if (same == true)
            {
                WriteLine("The numbers are the same");
            }
            else
            {
                WriteLine("The numbers are not the same");
            }



        }//end of Are Same Method

       /* static void ThirdElementAverage(int[] numbers)
        {
            int j, sum, average, denom = 0;



            sum = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                j = numbers[i];

                if (j % 3 = 0)
                {
                    sum = sum + numbers[i];

                    denom = denom + 1;

                }

            }
            average = sum / denom;

            WriteLine(average);


        }//end of third element Method*/

        static void standDev(int[] numbers)
        {
            int differencesum = 0, mean, variance,  sum = 0;



            int[] differences;

            differences = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            mean = sum / numbers.Length;

            for (int j = 0; j < numbers.Length; j++)
            {
                differences[j] = numbers[j] - mean;
            }

            for (int i = 0; i < differences.Length; i++)
            {
                differences[i] = differences[i] * differences[i];

                differencesum = differencesum + differences[i];

            }

            variance = differencesum / differences.Length;

            WriteLine(Math.Sqrt(variance));



        }//end of Stand Dev method




        










    }
}

