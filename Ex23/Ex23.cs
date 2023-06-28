namespace Ex23
{
    internal class Ex23
    {
        const int headMin = 1;
        const int headMax = 1000;
        const int legMin = 2;
        const int legMax = int.MaxValue;
        static void Main(string[] args)
        {
            var turtle = 0;
            var crane = 0;
            while (true)
            {
                var head = InputInt("頭の数を入力してください", headMin, headMax);
                var leg = InputInt("脚の数を入力してください", head*2, head*4);
                var tempTurtle = (float)leg / 2 - head;
                var tempCrane = (float)head - tempTurtle;
                if (isNaturalNumber(tempTurtle) && isNaturalNumber(tempCrane))
                {
                    turtle = (int)tempTurtle;
                    crane = (int)tempCrane;
                    break;
                }
                Console.WriteLine("入力値が異常です");
            }
            Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
        }


        public static bool isNaturalNumber(double number)
        {
            return (number > 0 && Math.Floor(number) == number);
        }
        public static int InputInt(string message)
        {
            int i;
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    break;
                }
                Console.WriteLine("入力エラー");
            }
            return i;
        }

        public static int InputInt(string message, int min, int max)
        {
            int i;
            while (true)
            {
                i = InputInt($"{message} 値の範囲は{min}以上・{max}未満");
                if (i >= min && i < max)
                {
                    break;
                }
                Console.WriteLine("入力範囲エラー");
            }
            return i;

        }
    }
}