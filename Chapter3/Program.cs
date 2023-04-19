namespace Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5200000000001;
            byte b = 0xff;               // 16進数
            var c = 0b00010100; // 2進数
            var s = $"aの値段は\\{a}で,\nbの値は{b}で,\nｃの値は{c}です。";
            Console.WriteLine(s);
            var judge = a < b ;
            int x = 100;
            byte y = 20;
            y = (byte)(x + y);
            b =(byte)( a + c);
            Console.WriteLine($"b=a+c={b}");
            Console.WriteLine($"a < bは{judge}");
        }
    }
}