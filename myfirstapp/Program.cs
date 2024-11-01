namespace myfirstapp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          // Console.WriteLine("Hello World!");
          WriteTable(6, "text");
          /*
          int inputNumber = int.Parse(Console.ReadLine());
          string? inputString = Console.ReadLine();
          
          WriteTable(inputNumber, inputString);
          */
          
        }

        private static void WriteTable(int n, string s)
        {
            if (n is < 1 or > 6)
            {
                Console.WriteLine("Enter the correct number:");
            }

            int weight = s.Length + 2 * (n - 1);
            for (int i = 1; i <= weight; i++)
            {
                Console.Write('+');
            }
        }

    }

}    