using System;
using System.Collections.Generic;

namespace TestFrontendDev
{
    class HotelsTest
    {
        //First
        static string Cities(string[] cities)
        {
            string formatCities = null;

            for (int i = 0; i < cities.Length; i++)
            {
                if (i + 1 != cities.Length)
                    formatCities += cities[i] + ", ";
                else formatCities += cities[i];
            }

            return formatCities + ".";
        }
        //Second
        static float RoundNumber(float number)
        {
            var resultNumber = Math.Round(number);
            var increaseValue = resultNumber;
            var decreaseValue = resultNumber;

            while (true)
            {
                increaseValue++;
                decreaseValue--;
                if (increaseValue % 5 == 0)
                    return (float)increaseValue;
                else if (decreaseValue % 5 == 0)
                    return (float)decreaseValue;
            }
        }
        //Third
        static string ComputersCount(int computersCount)
        {
            string computersStr = computersCount.ToString();
            int[] array = new int[computersStr.Length];

            for (int i = 0; i < computersStr.Length; i++)
                array[i] = Convert.ToInt32(computersStr[i].ToString());

            if (array[array.Length - 1] == 1 && (array.Length == 1 || array[array.Length - 2] != 1))
                return computersCount + " компьютер";
            else if (array[array.Length - 1] != 1 && array[array.Length - 1] >= 2 && array[array.Length - 1] <= 4
                && (array.Length == 1 || array[array.Length - 2] != 1))
                return computersCount + " компьютера";
            else return computersCount + " компьютеров";
        }
        //Fourth
        static bool IsNumberPrime(int number)
        {
            if (number != 2 && number != 3 && number != 5 && number != 7 &&
                (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0 || number == 1))
                return false;
            return true;
        }
        //Fifth
        static int[] SameArrayElements(int[] firstArray, int[] secondArray)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < firstArray.Length; i++)
            {
                int sameNumbersCount = 0;
                for (int j = 0; j < firstArray.Length; j++)
                    if (i != j && firstArray[i] == firstArray[j])
                        for (int k = 0; k < secondArray.Length; k++)
                            if (firstArray[i] == secondArray[k] && !list.Contains(firstArray[i]))
                            {
                                sameNumbersCount++;
                                if (sameNumbersCount > 1)
                                    list.Add(firstArray[i]);
                            }

            }
            return list.ToArray();
        }
        //Sixth
        static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i == 1)
                    for (int k = 0; k <= number; k++)
                    {
                        if (k == 0)
                            Console.Write(" ");
                        else Console.Write($" {k} ");
                    }

                Console.WriteLine("");
                Console.Write($"{i} ");

                for (int j = 1; j <= number; j++)
                {
                    Console.Write($"{j * i} ");
                    if ((j + 1) * i < 10)
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}