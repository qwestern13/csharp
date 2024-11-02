namespace myfirstapp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          // Console.WriteLine("Hello World!");
          WriteTable(6, "test");
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
                return;
            }

            if (s.Equals(""))
            {
                Console.WriteLine("Enter the text:");
                return;
            }

            int weight = s.Length + 2 * (n - 1);
            int heightCenter = (int)Math.Floor((double)((2 * n - 1) / 2));

            if (weight > 40)
            {
                return;
            }

            /*for (int i = 1; i <= weight; i++)
            {
                Console.Write('+');
            }
            Console.WriteLine();*/
            CrossLine(weight);
            
            for (int i = 1; i < 2 * n - 1; i++)
            {
                Console.Write('+');
                if(i == heightCenter)
                {
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(s);
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write(' ');
                    }
                }
                else
                {
                    for (int j = 1; j <= weight - 2; j++)
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('+');
                Console.Write('\n');
            }
            CrossLine(weight);
        }
        
        private static void CrossLine(int weight)
        {
            for (int i = 1; i <= weight; i++)
            {
                Console.Write('+');
            }
            Console.WriteLine();
            
        }

    }

}