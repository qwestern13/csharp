namespace myfirstapp
{
    // chars
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is start");

            // chars
            Console.WriteLine(char.IsWhiteSpace('r'));
            Console.WriteLine(char.ToUpper('r'));
            Console.WriteLine(char.IsPunctuation('.'));

            // string
            Console.WriteLine("this is home directory: /home/user/");
            Console.WriteLine("this is system folder: C:\\Windows\\System32");
            Console.WriteLine(@"this is system folder: C:\Windows\System32");

            // interpolation
            var name = "John";
            var info = $"Hello, {name}!";
            Console.WriteLine(info);
        }
    }
}
