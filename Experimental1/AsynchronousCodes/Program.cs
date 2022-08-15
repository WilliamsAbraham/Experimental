using System;
using System.Threading.Tasks;

namespace AsynchronousCodes
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
           await ToastAsync(2);
        }
        static async Task<Toast> ToastAsync (int slices)
        {
            await Task.Delay(200);

            return new Toast();  

        }
    }
    public class Toast
    {
       

    }

    public class Egg
    {
        public string Name { get; set; }
    }

    public class Juice
    {

    }
}
