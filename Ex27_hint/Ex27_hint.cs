using System;

namespace Ex27_hint
{
    internal class Ex27
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(
                (float)InputUtility.InputNumber("幅："),
                (float)InputUtility.InputNumber("高さ：")
            );
            Rectangle rectangle1 = new Rectangle(3, 2.5f);
            Console.WriteLine($"rectangleの面積は{rectangle.GetSurface()}、周囲の長さは{rectangle.GetPerimeter()}");
            Console.WriteLine($"rectangle1の面積は{rectangle1.GetSurface()}、周囲の長さは{rectangle1.GetPerimeter()}");

            Box box = new Box(
                (float)InputUtility.InputNumber("幅："),
                (float)InputUtility.InputNumber("高さ："),
                (float)InputUtility.InputNumber("奥行：")
               );

            Box box1 = new Box(3, 4.5f, 7);
            // 作られたboxのインスタンスを用いて表面積と体積を取り出して表示
            Console.WriteLine($"boxの表面積は{box.GetSurface()}、体積は{box.GetVolume()}");
            Console.WriteLine($"box1の表面積は{box1.GetSurface()}、体積は{box1.GetVolume()}");
        }
    }
    // 平面の図形
    /*以下がテンプレになる
    class Xxx
    {
        // 保持する変数

        // コンストラクタ
        public Xxx( 必要なパラメータ)
        {
            保持する値にコピー
        }
        //面積を取得
        public float GetSurface()
        {
            //面積を求め返す    
        }
        //周囲の長さを取得
        public float GetPerimeter()
        {
            // 周囲の長さを求め返す
        }
    }    
    */


    class Rectangle
    {
        private float width;    // 幅
        private float height;   // 高さ
        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        //面積を取得
        public float GetSurface()
        {
            return width * height;
        }
        //周囲の長さを取得
        public float GetPerimeter()
        {
            return (width + height) * 2;
        }

    }

    // Boxクラスをこの下に作る
    class Box
    {
        private float width;    // 幅
        private float height;   // 高さ
        private float depth;    // 奥行

        public Box(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
        //表面積を取得するメソッドGetSurfaceが在る
        public float GetSurface()
        {
            //計算する
            return (width * height + depth * height + width * depth) * 2; //表面積を計算し返す 
        }
        //体積を取得するメソッドGetVolumeが在る
        public float GetVolume()
        {
            return width * height * depth;   //体積を計算し返す
        }
    }

    //使うときはここからコピー==============

    /// <summary>
    /// Input用の汎用class
    /// </summary>
    class InputUtility
    {
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

        public static double InputNumber(string message, double min, double max, string errMessage = "入力範囲エラー")
        {
            double i;
            while (true)
            {
                i = InputNumber($"{message} 値の範囲は{min}以上・{max}未満");
                if (i >= min && i < max)
                {
                    break;
                }
                Console.WriteLine(errMessage);
            }
            return i;
        }

    }

    // ここまでコピー==============

}