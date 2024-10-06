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
            var busy = "How are you?";
            Console.WriteLine(info);
            Console.WriteLine($"{info} I'm fine, 10x! And... {busy}");

            // date
            Console.WriteLine($"It's time to make a change: {DateTime.Now:dd'/'MM'/'yyyy}!");
            Console.WriteLine($"It's time to make a new format: |{DateTime.Now,15:dd'/'MM'/'yyyy}|");

            // imm
            var plus = "Plus!";
            // plus[1] = "error";
            Console.WriteLine(plus[3]);

            // inter
            var s1 = "Hel";
            var s2 = "Hel" + "lo!";
            var s3 = "lo";
            var s4 = $"Hel{s3}";
            Console.WriteLine(s2 + "\n" + s4.Replace("Hel", "Al"));
            Console.WriteLine(s2 == s4);
        }
    }
}
