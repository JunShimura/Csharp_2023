namespace InputUtility
{
    public class InputValue
    {
        public static string InputString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static double InputNumber(string message)
        {
            double i;
            while (true)
            {
                Console.WriteLine(message);
                if (double.TryParse(Console.ReadLine(), out i))
                {
                    break;
                }
                Console.WriteLine("入力エラー");
            }
            return i;
        }

        public static double InputNumber(string message, double min, double max)
        {
            double i;
            while (true)
            {
                i = InputNumber($"{message} 値の範囲は{min}以上・{max}未満");
                if (i >= min && i < max)
                {
                    break;
                }
                Console.WriteLine("入力範囲エラー");
            }
            return i;
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