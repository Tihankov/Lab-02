using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab2_1
{
    class Program
    {
        private static void Avg(object mas)
        {
            int[] arr = (int[])mas;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            result = result / arr.Length;
            Thread.Sleep(2000);
            Console.WriteLine("Avarage of array:{0} ", result);

        }
        static void MaxNeg(object mas)
        {
            int[] arr = (int[])mas;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    result = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && result < arr[i])
                {
                    result = arr[i];
                }
            }
            Thread.Sleep(4000);
            Console.WriteLine("Maximum negative number of array:{0} ", result);
        }
        static void MinPos(object mas)
        {
            int[] arr = (int[])mas;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    result = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && result > arr[i])
                {
                    result = arr[i];
                }
            }
            Thread.Sleep(6000);
            Console.WriteLine("Minimum positive number of array:{0} ", result);
        }


        static void Main(string[] args)
        {
            int[] mas = new int[15];
            Random r = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-200, 201);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();

            Task t1 = new Task(() => Avg(mas));
            t1.Start();

            Task t2 = new Task(() => MaxNeg(mas));
            t2.Start();

            Task t3 = new Task(() => MinPos(mas));
            t3.Start();

            Console.ReadKey();
        }
    }
}