namespace myfirstapp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          WriteTable(3, "testtt");

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

            int wight = s.Length + 2 * (n - 1);
            int height = 2 * n - 1;

            if (wight > 40)
            {
                return;
            }

            CrossLine(wight);
            
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                Console.Write('+');
                if(i == n)
                {
                    for (int j = 1; j <= n - 1; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(s);
                    for (int j = 1; j <= n - 1; j++)
                    {
                        Console.Write(' ');
                    }
                }
                else
                {
                    for (int j = 1; j <= wight; j++)
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('+');
                Console.Write('\n');
            }
            CrossLine(wight);
            ChessDeck(wight, height);
        }
        
        private static void CrossLine(int wight)
        {
            for (int i = 1; i <= wight + 2; i++)
            {
                Console.Write('+');
            }
            Console.WriteLine();
            
        }

        public static void ChessDeck(int wight, int height)
        {
            string crosses = "";
            int i = 0;
            bool isCross = false;
            for (int j = 1; j <= height; j++)
            {
                while (i < wight)
                {
                    if (isCross && j % 2 == 0)
                    {
                        crosses += "+";
                        isCross = false;
                    }
                    else if (!isCross && j % 2 == 0)
                    {
                        crosses += " ";
                        isCross = true;
                    }
                    else if (!isCross && j % 2 != 0)
                    {
                        crosses += " ";
                        isCross = true;
                    }
                    else if (!isCross && j % 2 != 0)
                    {
                        crosses += " ";
                        isCross = true;
                    }
                    i++;
                }
            }

            Console.Write("+");
            Console.Write(crosses);
            Console.Write("+");

        }
        
        

    }

}