﻿namespace Ex25_struct;

internal class Program
{
    struct QuadraticFunctionAnswer
    {
        public bool result;
        public float ans1;
        public float ans2;
    }
    static void Main(string[] args)
    {
        float a = (float)InputNumber("変数a=");
        float b = (float)InputNumber("変数b=");
        float c = (float)InputNumber("変数c=");
        QuadraticFunctionAnswer ans = QuadraticFunction(a, b, c);
        if (ans.result)
        {   // 実数解あり
            Console.WriteLine($"実数解あり");
            if (ans.ans1 == ans.ans2)
            {
                Console.WriteLine($"解={ans.ans1}で重解");
            }
            else
            {
                Console.WriteLine($"解={ans.ans1},{ans.ans2}");
            }
        }
        else
        {   // 虚数解
            Console.WriteLine($"実数解なし");
        }

    }
    /// <summary>
    /// 二次関数の解を求める
    /// </summary>
    /// <param name="a">x^2の係数</param>
    /// <param name="b">xの係数</param>
    /// <param name="c">定数</param>
    /// <param name="ans1">解1</param>
    /// <param name="ans2">解2</param>
    /// <returns>実数解があるか</returns>
    //static bool QuadraticFunction(float a, float b, float c, out float ans1, out float ans2)
    static QuadraticFunctionAnswer QuadraticFunction(float a, float b, float c)
    {
        float discriminant = b * b - 4 * a * c; // 判別式の計算

        QuadraticFunctionAnswer results = new QuadraticFunctionAnswer();
        if (discriminant >= 0)
        {
            // 実数解が存在する場合
            results.result = true;
            results.ans1 = (float)((-b + Math.Sqrt(discriminant)) / (2 * a));
            results.ans2 = (float)((-b - Math.Sqrt(discriminant)) / (2 * a));
        }
        else
        {
            // 実数解が存在しない場合
            results.result = false;
        }
        return results;
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