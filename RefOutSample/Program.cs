namespace RefOutSample;

internal class Program
{

    const int headMin = 1;
    const int headMax = 1000;
    const int legMin = 2;
    const int legMax = int.MaxValue;
    static void Main(string[] args)
    {
        int turtle;
        int crane ;
        while (true)
        {
            int head;
            if (GetCraneTurtle(
                head=InputInt("頭の数を入力してください", headMin, headMax),
                InputInt("脚の数を入力してください", head * 2, head * 4 + 1),
                out crane, out turtle))
            {
                break;
            }
            Console.WriteLine($"入力値が異常です。鶴={crane}");
        }
        Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
    }

    static bool GetCraneTurtle(int heads, int legs, out int crane, out int turtle)
    {
        crane = 0;
        turtle = 0;
        bool result;
        var tempTurtle = (float)legs / 2 - heads;
        var tempCrane = (float)heads - tempTurtle;
        if (isNaturalNumberOr0(tempTurtle) && isNaturalNumberOr0(tempCrane))
        {
            turtle = (int)tempTurtle;
            crane = (int)tempCrane;
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }


    public static bool isNaturalNumberOr0(double number)
    {
        return (number == 0 || isNaturalNumber(number));
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