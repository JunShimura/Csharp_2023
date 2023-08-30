namespace Ex27;
using System.Linq;

using System;
using System.Security.Cryptography;

internal class Ex27
{
    static void Main(string[] args)
    {
        float r = (float)InputUtility.InputNumber("円の半径：");
        Console.WriteLine(Circle.GetSurface(r));

        Rectangle rectangle = new Rectangle(
            (float)InputUtility.InputNumber("長方形の幅："),
            (float)InputUtility.InputNumber("長方形の高さ：")
        );
        Console.WriteLine($"rectangleの面積は{rectangle.GetSurface()}、周囲の長さは{rectangle.GetPerimeter()}");

        Circle circle = new Circle(
            (float)InputUtility.InputNumber("円の半径：")
            );
        Console.WriteLine($"circleの面積は{circle.GetSurface()}、周囲の長さは{circle.GetPerimeter()}");

        Triangle triangle = new Triangle(
            (float)InputUtility.InputNumber("辺1の長さ："),
            (float)InputUtility.InputNumber("辺2の長さ："),
             (float)InputUtility.InputNumber("辺3の長さ：")
            );
        Console.WriteLine($"triangleの面積は{triangle.GetSurface()}、周囲の長さは{triangle.GetPerimeter()}");

        Box box = new Box(
            (float)InputUtility.InputNumber("幅："),
            (float)InputUtility.InputNumber("高さ："),
            (float)InputUtility.InputNumber("奥行：")
           );
        Console.WriteLine($"boxの表面積は{box.GetSurface()}、体積は{box.GetVolume()}");
        Sphere sphere = new Sphere(
            (float)InputUtility.InputNumber("球の半径：")
           );
        Console.WriteLine($"sphereの表面積は{sphere.GetSurface()}、体積は{sphere.GetVolume()}");
        //Cylinder TriangulerPrizm cone
        Cylinder cylinder = new Cylinder(circle, 5);
        Console.WriteLine($"cylinderの表面積は{cylinder.GetSurface()}、体積は{cylinder.GetVolume()}");
        TriangularPrism triangularPrism = new TriangularPrism(triangle, 5);
        Console.WriteLine($"triangularPrismの表面積は{triangularPrism.GetSurface()}、体積は{triangularPrism.GetVolume()}");
        Cone cone = new Cone(circle, 5);
        Console.WriteLine($"coneの表面積は{cone.GetSurface()}、体積は{cone.GetVolume()}");
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
class Circle
{
    private float radius;
    public Circle(float radius)
    {
        this.radius = radius;
    }

    public float GetRadius()
    {
        return radius;
    }
    //面積を取得
    public float GetSurface()
    {
        return (float)(Math.PI * radius * radius);
    }
    public static float GetSurface(float radius)
    {
        return (float)(Math.PI * radius * radius);

    }
    //周囲の長さを取得
    public float GetPerimeter()
    {
        return (float)(Math.PI * radius);
    }
}
class Triangle
{
    private float side1;
    private float side2;
    private float side3;
    public Triangle(float side1, float side2, float side3)
    {
        float[] t = new float[3];
        t[0] = this.side1 = side1;
        t[1] = this.side2 = side2;
        t[2] = this.side3 = side3;
        float[] t2 = t.OrderBy(x => x).ToArray<float>();
        if (t2[2] >= (t2[0] + t2[1]))
        {
            throw new ArgumentException("Invalid Parameter");
        }
    }
    //面積を取得
    public float GetSurface()
    {
        double s = (double)((side1 + side2 + side3) / 2);
        double t = s * (s - side1) * (s - side2) * (s - side3);
        t = Math.Sqrt(t);
        return (float)t;
    }
    //周囲の長さを取得
    public float GetPerimeter()
    {
        return side1 + side2 + side3;
    }
}

// Boxクラスをこの下に作る
class Box
{
    private Rectangle rectangle;
    private float height;   // 高さ

    public Box(Rectangle rectangle, float height)
    {
        this.rectangle = rectangle;
        this.height = height;
    }
    public Box(float width, float height, float depth)
    {
        rectangle = new Rectangle(width, depth);
        this.height = height;
    }
    //表面積を取得するメソッドGetSurfaceが在る
    public float GetSurface()
    {
        //計算する
        return (rectangle.GetSurface() * 2 + rectangle.GetPerimeter() * height); //表面積を計算し返す 
    }
    //体積を取得するメソッドGetVolumeが在る
    public float GetVolume()
    {
        return rectangle.GetSurface() * height;   //体積を計算し返す
    }
}
class Cylinder
{
    private Circle circle;
    private float height;

    public Cylinder(Circle circle, float height)
    {
        this.circle = circle;
        this.height = height;
    }
    public Cylinder(float radius, float height)
    {
        this.circle = new Circle(radius);
        this.height = height;
    }
    public float GetSurface()
    {
        //計算する
        return (float)(circle.GetSurface() * 2 + circle.GetPerimeter() * height); //表面積を計算し返す 
    }
    public float GetVolume()
    {
        return (float)(circle.GetSurface() * height);   //体積を計算し返す
    }
}
class Sphere
{
    private float radius;
    public Sphere(float radius)
    {
        this.radius = radius;
    }
    public float GetSurface()
    {
        //計算する
        return (float)(radius * radius * Math.PI * 4); //表面積を計算し返す 
    }
    public float GetVolume()
    {
        return (float)(radius * radius * radius * Math.PI * 4 / 3);   //体積を計算し返す
    }
}
class TriangularPrism
{
    private Triangle triangle;
    private float height;

    public TriangularPrism(Triangle triangle, float height)
    {
        this.triangle = triangle;
        this.height = height;
    }
    public TriangularPrism(float side1, float side2, float side3, float height)
    {
        this.triangle = new Triangle(side1, side2, side3);
        this.height = height;
    }
    public float GetSurface()
    {
        //計算する
        return (float)(triangle.GetSurface() * 2 + triangle.GetPerimeter() * height); //表面積を計算し返す 
    }
    public float GetVolume()
    {
        return (float)(triangle.GetSurface() * height);   //体積を計算し返す
    }
}
class Cone
{
    private Circle circle;
    private float height;

    public Cone(Circle circle, float height)
    {
        this.circle = circle;
        this.height = height;
    }
    public Cone(float radius, float height)
    {
        circle = new Circle(radius);
        this.height = height;
    }
    public float GetSurface()
    {
        double r2 = Math.Sqrt(circle.GetRadius() * circle.GetRadius() + height * height);
        return (float)(circle.GetSurface() + r2 * r2 * Math.PI * circle.GetRadius() / r2);
    }
    public float GetVolume()
    {
        return (float)((double)circle.GetSurface() * height / 3);
    }


}

class TriangularPyramid
{

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
