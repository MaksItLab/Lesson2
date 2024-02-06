using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //string str = "asdfdsf";

            //int[] array = new int[a];

            //int[] array_1 = new int[5] {1, 2, 3, 4, 5};

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //int[,] array2 = new int[3,6];

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    for(int j = 0; j < 6; j++)
            //    {
            //        Console.Write(array2[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int[] array3 = new int[6] {8, -3, -35, 0, 10, 90};

            //for (int i = 0; i < array3.Length; i++)
            //{
            //    array3[i] = Console.Read();
            //}

            //for (int i = 0; i < array3.Length; i++)
            //{
            //    Console.Write(array3[i] + " ");
            //}

            //Console.WriteLine();

            //BubbleSort(array3);

            //for (int i = 0; i < array3.Length; i++)
            //{
            //    Console.Write(array3[i] + " ");
            //}

            //DateTime dt = new DateTime();
            //Console.WriteLine(dt);

            DateTime dt_1 = DateTime.Now;
            Console.WriteLine(dt_1);

            int[] array = new int[20] {34, 0, 12, -1, -234, 45, 100, -12, 23, 95, -45, -100, 34, 34, 0, -123, -1, -34, 28, 21};

            array = BubbleSort(array);

            DateTime dt_2 = DateTime.Now;
            Console.WriteLine(dt_2);

            Console.WriteLine(dt_1.Subtract(dt_2));

            

        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
