namespace myfirstapp
{

    // class and methods
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");

            var sum1 = StaticSum(6, 7);
            Console.WriteLine("sum1 = " + sum1);

            var test = MyFirstClass.MyFirstMethod(6, 9);
            Console.WriteLine(test);

            var MyClass = new MyFirstClass();
            var sum3 = MyClass.MySecondMethod(21, 7);
            Console.WriteLine(sum3);

            WriteLineCustomString("Void method");
            WriteLineHelloCSharp();


            var factorial = Fact(5);
            Console.WriteLine("factorial = " + factorial);

            var weather = MyIFClass.MyIFMethod(null);
            Console.WriteLine("Weather: " + weather);

            var coloroftheday = MyIFClass.MySWITCHMethod(null);
            Console.WriteLine($"Cvet nastroeniya " + coloroftheday);
        }

        public static int StaticSum(int a, int b)
        {
            var sum = a + b;

            return sum;
        }
        
        public static void WriteLineCustomString(string s)
        {
            Console.WriteLine(s);
        }

        public static void WriteLineHelloCSharp()
        {
            Console.WriteLine("Hello, CSharp!");
        }

        public static int Fact(int n)
        {
            if (n == 1)
                return 1;

            return n * Fact(n - 1);
        }

    }

    public class MyFirstClass
    {
        public static int MyFirstMethod(int a, int b)
        {
            Console.WriteLine("test new class and method");

            var sum2 = a + b + 1;

            return sum2;
        }

        public int MySecondMethod(int a, int b)
        {
            Console.WriteLine("this is the second class");

            var sum = a + b + 1;

            return sum;
        }

    }

    // if

    public class MyIFClass : MyIFClassBase
    {

        public static string MyIFMethod(string[]? args)
        {
            var temperature = 20;

            Console.WriteLine($"This is temp: {temperature}");

            if (temperature == 20)
            {
                return $"If temperature == {temperature} this is horosho!";
            }
            else
            {
                return "Not horosho!";
            }

        }
    }

}
