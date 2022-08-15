using PinGen;

struct Test
{
    public int Number { get; set; }

    public Test(int number)
    {
        Number = number;
    }
}
class Program
{
    static void Main(string[] args)
    {
        PinGenerator Pin = new PinGenerator(10);
        Pin.Genearate();

        //Test test = new Test(10);
        //Console.WriteLine(test.Number);

        //ChangeNumber(test);
        //Console.WriteLine(test.Number);

        // decimal d = 1.222;
    }

    public static void ChangeNumber(Test test)
    {
        test.Number = 45;
    }
}