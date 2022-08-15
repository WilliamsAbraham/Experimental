using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental1
{
    public class UserAgeCollection

    {
        public void UserAgeRecord ()
        {
            Console.WriteLine("Please Input your age");

            var userAge = Console.ReadLine ();

            Console.WriteLine (userAge);
        }

    }
}
