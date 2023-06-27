using System;

namespace Ex22_hint
{
    class Ex22_hint
    {

        const float rMin = 1; //半径の最小値
        const float rMax = 100; //半径の最小値
        const float hMin = 1; //高さの最小値
        const float hMax = 300; //高さの最大値

        static void Main(string[] args)
        {
            float r = 0; //半径
                         //　半径の入力処理
            while (true)
            {
                Console.WriteLine($"半径は幾つですか？\n範囲は{rMin}から{rMax}");
                if (float.TryParse(Console.ReadLine(), out r))
                {
                    if (r >= rMin && r < rMax)
                    { //値は適正
                        break;
                    }
                    Console.WriteLine("入力エラー");
                }
            }
            float h = 0; //高さ
            while (true)
            {
                Console.WriteLine($"高さは幾つですか？\n範囲は{hMin}から{hMax}");
                if (float.TryParse(Console.ReadLine(), out h))
                {
                    if (h >= hMin && h < hMax)
                    { //値は適正
                        break;
                    }
                }
                Console.WriteLine("入力エラー");
            }

            float s = 0; //底面積
            float v = 0; //体積

            //ここに処理を追加
            s = GetCircleSurface(r);
            v = GetCylinderVolume(r, h);

            Console.WriteLine("底面積は{0},体積は{1}", s, v);
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
    }

}



