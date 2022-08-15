using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserAgeRecord();
        }
         public static void UserAgeRecord ()
        {

            Console.WriteLine("input your age");

            int trial = 10;
            int age = 0;
            bool isAgeInt = false;

            while(trial>0 &&!isAgeInt)
            {
                Console.WriteLine($"please input a correct Age formate,you have {trial}  number of trial remaining");

                isAgeInt = int.TryParse(Console.ReadLine(), out age);
                trial--;

            }

            if (age < 10)
            {
                Console.WriteLine("you are too young");
            }
            else if (age >= 11 && age <= 20)
            {
                Console.WriteLine("you're a mid-aged individual");
            }
            else if (age > 20 && age < 30)
            {
                Console.WriteLine("you're faily young");
            }
            else 
            {
                Console.WriteLine("We couldn't find a good match for you");
            }

            Console.ReadKey();
        }
        
      
    }
}
