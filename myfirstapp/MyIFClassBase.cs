namespace myfirstapp
{
    public class MyIFClassBase
    {

        public static string MySWITCHMethod(string[]? args)
        {

            string color = "Red";

            switch (color)
            {
                case "G":
                    Console.Write("Green");
                    break;

                case "B":
                    Console.Write("Blue");
                    break;

                //case "Y":
                //    Console.Write("Yellow");
                //    break;

                case "red":
                    Console.Write("This is REEED!");
                    break;

                default:
                    return "Other color!";
            }

            return "this is switch!";

        }
    }
}