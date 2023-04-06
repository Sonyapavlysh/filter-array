using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int arrLength = Int32.Parse(Console.ReadLine());
        Finding(arrLength);
    }

    static void Finding(int arrLength)
    {
        List<string> arrayList = new List<string>();
        for (int i = 0; i < arrLength; i++)
        {
            string elem = Console.ReadLine();
            arrayList.Add(elem);
        }

        string[] array = arrayList.ToArray();

        List<string> resultList = new List<string>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                resultList.Add(array[i]);
            }
        }

        for (int i = 0; i < resultList.ToArray().Length; i++)
        {
            Console.Write(resultList[i]);
            Console.Write(" ");
        }
    }
}
