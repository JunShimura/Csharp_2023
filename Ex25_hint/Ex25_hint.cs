namespace Ex25_hint;

internal class Ex25_hint
{
    static void Main(string[] args)
    {
        float a = (float)InputNumber("変数a=");
        float b = (float)InputNumber("変数b=");
        float c = (float)InputNumber("変数c=");
        float ans1;
        float ans2;
        bool result= QuadraticFunction(a, b, c,out ans1,out ans2);

    }
    static bool QuadraticFunction(float a, float b, float c,out float ans1, out float ans2)
    {
        ans1=0; ans2=0;
        return true;
    }

    private static double InputNumber(string message)
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

    private static double InputNumber(string message, double min, double max)
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
}