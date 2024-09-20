namespace myfirstapp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, C#!");

            var sum1 = StaticSum(6, 7);
            Console.WriteLine("sum1 = " + sum1);

            var test = MyFirstClass.MyFirstMethod(6, 9);
            Console.WriteLine(test);

        }

        public static int StaticSum(int a, int b)
        {

            var sum = a + b;

            return sum;
        }
    }

    public class MyFirstClass
    {
        public static int MyFirstMethod(int a, int b)
        {
            Console.WriteLine("test new class and method");

            var sum = a + b + 1;

            return sum;
        }
    }

}
