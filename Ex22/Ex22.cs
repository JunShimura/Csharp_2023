namespace Ex22;

internal class Ex22
{

    const float rMin = 1; //半径の最小値
    const float rMax = 100; //半径の最小値
    const float hMin = 1; //高さの最小値
    const float hMax = 300; //高さの最大値

    static void Main(string[] args)
    {
        float r = (float)InputNumber("半径は幾つですか？",rMin,rMax); //半径
        float h = (float)InputNumber("高さは幾つですか？", hMin, hMax); //高さ
        Console.WriteLine($"底面積は{GetCircleSurface(r)},体積は{GetCylinderVolume(r, h)}");
    }
    static float GetCircleSurface(float radius)
    {  //半径から円の面積を求める
        float surface = 0;
        //　ここに処理を追加
        surface = (float)Math.PI * radius * radius;
        return surface;
    }
    static float GetCylinderVolume(float radius, float height)
    {  //半径と高さから円柱の体積を求める
        float volume = GetCircleSurface(radius) * height;
        return volume;
    }
    // MethodSampleから移植
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