namespace DimentionSampleCoin
{
    internal class DimentionSampleCoin
    {
        static void Main(string[] args)
        {
            int[] coin = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };
            string[] unit = { "札", "札", "札", "札", "玉", "玉", "玉", "玉", "玉", "玉" };

            Console.WriteLine("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            for (var i = 0; i < coin.Length; i++)
            {
                var n = money / coin[i];
                if (n != 0)
                {
                    Console.WriteLine($"{coin[i]}円{unit[i]}：{n}枚");
                }
                money %= coin[i];
            }
        }
    }
}