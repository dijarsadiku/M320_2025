namespace M320_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 2;
            int b = 3;
            int summe = mymath.Add(a, b);
            Console.WriteLine($"Summe von {a} und {b} = {summe}");
        }
    }
}
