using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = {1,-2,3,-4,5};
            //PrintNumbers();

            //PrintOdds();

            //PrintSum();

            //LoopArray(array);

            //Console.WriteLine(FindMax(array));

            //Console.WriteLine(GetAverage(array));

            //int[] x = OddArray();
            //foreach (int num in x)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine(GreaterThanY(array, 3));

            //int[] x = SquareArrayValues(array);
            //foreach (int num in x)
            //{
            //    Console.WriteLine(num);
            //}

            //int[] x = EliminateNegatives(array);
            //foreach (int num in x)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine(MinMaxAvg(array));

            //int[] x = ShiftValues(array);
            //foreach (int num in x)
            //{
            //    Console.WriteLine(num);
            //}

            Object[] x = NumToString(array);
            foreach (Object thing in x)
            {
                Console.WriteLine(thing);
            }

        }

        public static void PrintNumbers()
        {
            for(int i = 0; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for(int i = 0; i<256; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i<256; i++)
            {
                sum += i;
                Console.WriteLine($"New Number: {i} New Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if( max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static int GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += i;
            }
            int avg = sum/numbers.Length;
            return avg;
        }

        public static int[] OddArray()
        {
            int length = 0;
            for(int i = 0; i<256; i++)
            {
                if(i % 2 != 0)
                {
                    length = length + 1;
                }
            }

            int[] oddarr = new int[length];
            
            int k = 0;
            for(int i = 0; k<oddarr.Length; i++)
            {
                if(i % 2 != 0)
                {
                    oddarr[k]=i;
                    k += 1;
                }
            }

        return oddarr;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {   
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count += 1;
                }
            }
            return count;
        }

        public static int[] SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i]*numbers[i];
            }
            return numbers;
        }

        public static int[] EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            return numbers;
        }

        public static string MinMaxAvg(int[] numbers)
        {
            int max = FindMax(numbers);
            int avg = GetAverage(numbers);
            int min = 0;

            for (int i = 0; i<numbers.Length; i++)
            {
                if(numbers[i]<min)
                {
                    min = numbers[i];
                }
            }
            return $"Min is {min}, Max is {max}, and average is {avg}";
        }

        public static int[] ShiftValues(int[] arr)
        {
            for (int i = 0; i<arr.Length; i++)
            {
                arr[0] = 0;
                for(int k = 0; k < arr.Length-1; k++)
                {
                    int temp = arr[k+1];
                    arr[k+1] = arr[0];
                    arr[0] = temp;
                }
            }
            return arr;
        }

        public static object[] NumToString(int[] arr)
        {
            Object[] things = new Object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    things[i] = "Dojo";
                }
                else
                {
                    things[i] = arr[i];
                }
            }
            return things;
        }
    }
}
