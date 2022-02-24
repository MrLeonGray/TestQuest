using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static int[][] arrayArrays;
        static void Main() => TestFunc(5);

        static void TestFunc(int n)
        {
            Random rand = new Random();
            List<int> randomList = new List<int>();

            arrayArrays = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int randInt;
                do
                {
                    randInt = rand.Next(n) + 1;
                } while (randomList.Contains(randInt));

                randomList.Add(randInt);
            }

            int[] randomArray = randomList.ToArray();

            Console.WriteLine("==========");
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }
            Console.WriteLine("==========");

            for (int i = 0; i < randomArray.Length; i++)
            {
                getArray(i, randomArray[i]);
            }
        }

        static void getArray(int index, int count)
        {
            List<int> numberList = new List<int>();

            for (int i = 0; i < count; i++)
            {
                numberList.Add(i+1);
            }
            arrayArrays[index] = numberList.ToArray();
        }
    }
}

    //На входе функция получает параметр n - натуральное число.
    //Необходимо сгенерировать n-массивов, заполнить их случайными числами, каждый массив имеет случайный размер.
    //Размеры массивов не должны совпадать.
//Далее необходимо отсортировать массивы.
//Массивы с четным порядковым номером отсортировать по возрастанию, с нечетным порядковым номером - по убыванию.
//На выходе функция должна вернуть массив с отсортированными массивами.