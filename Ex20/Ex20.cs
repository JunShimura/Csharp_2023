using System;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            float r = (float)InputNumber("半径：");
            Console.WriteLine($"底面積は{GetCircleSurface(r)},体積は{GetCylinderVolume(r, (float)InputNumber("高さ："))}");
        }
        static float GetCircleSurface(float radius)
        {  //半径から円の面積を求める
            return (float)(radius * radius * Math.PI);
        }
        static float GetCylinderVolume(float radius, float height)
        {  //半径と高さから円柱の体積を求める
            return GetCircleSurface(radius) * height;
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
    }
}

