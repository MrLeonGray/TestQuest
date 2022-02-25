using System;
using System.Linq;

namespace TestProject
{
    class Program
    {

        static void Main()
        {
            string val;
            int n;

            Console.Write("Введите количество массивов: ");

            val = Console.ReadLine();
            n = Convert.ToInt32(val);

            Console.WriteLine(n);
            TestFunc(n);
        }

        static void TestFunc(int n)
        {
            Random rand = new Random();
            int[][] arrayArrays = new int[n][];
            int[] randomArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int randInt;
                do
                {
                    randInt = rand.Next(n) + 1;
                } while (randomArray.Contains(randInt));

                randomArray[i] = randInt;
            }

            for (int i = 0; i < randomArray.Length; i++)
            {
                arrayArrays[i] = GetArray(randomArray[i]);
            }

            arrayArrays = SortArray(arrayArrays);
        }

        static int[] GetArray(int count)
        {
            Random rand = new Random();
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(count);
            }
            return array;
        }

        static int[][] SortArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int[] arr = array[i];
                if (i % 2==0)
                {
                    Array.Sort(arr);
                } else
                {
                    Array.Sort(arr);
                    Array.Reverse(arr);
                }
            }
            return array;
        }

    }
}
