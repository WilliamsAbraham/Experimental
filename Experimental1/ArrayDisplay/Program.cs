using System;

namespace ArrayDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            for (int i = 0, j = 0; i < myArray.Length && j < myArray.Length; j++, i++)
                if (myArray[i] % 2 == 0) Console.WriteLine(myArray[i]);
            if (myArray[j] % 2 != 0) Console.WriteLine(myArray[j]);
        }
    }
}
