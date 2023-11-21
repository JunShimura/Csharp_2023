using System.Linq;
using System;
using System.Security.Cryptography;

namespace Ex29;
internal class Ex29
{
    static void Main(string[] args)
    {
        float p1 = 3;
        float p2 = 4;
        float p3 = 5;
        float p4 = 2;

        Rectangle rectangle = new Rectangle(p1, p2);
        if (rectangle.GetPerimeter() == Rectangle.GetPerimeter(p1, p2))
        {
            Console.WriteLine("passed test1");
        }
        if (rectangle.GetSurface() == Rectangle.GetSurface(p1, p2))
        {
            Console.WriteLine("passed test2");
        }

        Circle circle = new Circle(p1);
        if (circle.GetPerimeter() == Circle.GetPerimeter(p1))
        {
            Console.WriteLine("passed test3");
        }
        if (circle.GetSurface() == Circle.GetSurface(p1))
        {
            Console.WriteLine("passed test4");
        }

        Triangle triangle = new Triangle(p1, p2, p3);
        if (triangle.GetPerimeter() == Triangle.GetPerimeter(p1, p2, p3))
        {
            Console.WriteLine("passed test5");
        }
        if (triangle.GetSurface() == Triangle.GetSurface(p1, p2, p3))
        {
            Console.WriteLine("passed test6");
        }

        RightTriangle rightTriangle = new RightTriangle(p1, p2);
        if (rightTriangle.GetPerimeter() == RightTriangle.GetPerimeter(p1, p2))
        {
            Console.WriteLine("passed test7");
        }
        if (rightTriangle.GetSurface() == RightTriangle.GetSurface(p1, p2))
        {
            Console.WriteLine("passed test8");
        }

        Box box = new Box(p1, p2, p3);
        if (box.GetSurface() == Box.GetSurface(rectangle, p3))
        {
            Console.WriteLine("passed test9");
        }
        if (box.GetSurface() == Box.GetSurface(p1, p2, p3))
        {
            Console.WriteLine("passed test10");
        }
        if (box.GetVolume() == Box.GetVolume(rectangle, p3))
        {
            Console.WriteLine("passed test11");
        }
        if (box.GetVolume() == Box.GetVolume(p1, p2, p3))
        {
            Console.WriteLine("passed test12");
        }

        Cylinder cylinder = new Cylinder(p1, p2);
        if (cylinder.GetSurface() == Cylinder.GetSurface(circle, p2))
        {
            Console.WriteLine("passed test13");
        }
        if (cylinder.GetSurface() == Cylinder.GetSurface(p1, p2))
        {
            Console.WriteLine("passed test14");
        }
        if (cylinder.GetVolume() == Cylinder.GetVolume(circle, p2))
        {
            Console.WriteLine("passed test15");
        }
        if (cylinder.GetVolume() == Cylinder.GetVolume(p1, p2))
        {
            Console.WriteLine("passed test16");
        }

        Sphere sphere = new Sphere(p1);
        if (sphere.GetSurface() == Sphere.GetSurface(p1))
        {
            Console.WriteLine("passed test17");
        }
        if (sphere.GetVolume() == Sphere.GetVolume(p1))
        {
            Console.WriteLine("passed test18");
        }

        TriangularPrism triangularPrism = new TriangularPrism(p1, p2, p3, p4);
        if (triangularPrism.GetSurface() == TriangularPrism.GetSurface(triangle, p4))
        {
            Console.WriteLine("passed test19");
        }
        if (triangularPrism.GetSurface() == TriangularPrism.GetSurface(p1, p2, p3, p4))
        {
            Console.WriteLine("passed test20");
        }
        if (triangularPrism.GetVolume() == TriangularPrism.GetVolume(triangle, p4))
        {
            Console.WriteLine("passed test21");
        }
        if (triangularPrism.GetVolume() == TriangularPrism.GetVolume(p1, p2, p3, p4))
        {
            Console.WriteLine("passed test22");
        }

        Cone cone = new Cone(p1, p2);
        if (cone.GetSurface() == Cone.GetSurface(circle, p2))
        {
            Console.WriteLine("passed test23");
        }
        if (cone.GetSurface() == Cone.GetSurface(p1, p2))
        {
            Console.WriteLine("passed test24");
        }
        if (cone.GetVolume() == Cone.GetVolume(circle, p2))
        {
            Console.WriteLine("passed test25");
        }
        if (cone.GetVolume() == Cone.GetVolume(p1, p2))
        {
            Console.WriteLine("passed test26");
        }

        /*
         *          Box box = new Box(
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
        */
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
    static public float GetSurface(float width, float height)
    {
        return width * height;
    }
    public float GetSurface()
    {
        return GetSurface(this.width, this.height);
    }
    //周囲の長さを取得
    static public float GetPerimeter(float width, float height)
    {
        return (width + height) * 2;
    }
    public float GetPerimeter()
    {
        return GetPerimeter(width, height);
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
    public static float GetSurface(float radius)
    {
        return (float)(Math.PI * radius * radius);
    }
    public float GetSurface()
    {
        return GetSurface(radius);
    }
    //周囲の長さを取得
    static public float GetPerimeter(float radius)
    {
        return (float)(Math.PI * radius);
    }
    public float GetPerimeter()
    {
        return GetPerimeter(this.radius);
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
    public Triangle(float side1, float side2)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = (float)(Math.Sqrt((side1 * side1) + (side2 * side2)));
    }


    //面積を取得
    static public float GetSurface(float side1, float side2, float side3)
    {
        double s = (double)((side1 + side2 + side3) / 2);
        double t = s * (s - side1) * (s - side2) * (s - side3);
        t = Math.Sqrt(t);
        return (float)t;
    }
    public float GetSurface()
    {
        return GetSurface(this.side1, this.side2, this.side3);
    }
    //周囲の長さを取得
    static public float GetPerimeter(float side1, float side2, float side3)
    {
        return side1 + side2 + side3;
    }
    public float GetPerimeter()
    {
        return GetPerimeter(side1, side2, side3);
    }
}

class RightTriangle
{
    private float side1;
    private float side2;
    public RightTriangle(float side1, float side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    //面積を取得
    static public float GetSurface(float side1, float side2)
    {
        return (float)((double)side1 * side2 / 2);
    }
    public float GetSurface()
    {
        return GetSurface(side1, side2);
    }
    //周囲の長さを取得
    static public float GetPerimeter(float side1, float side2)
    {
        return (float)(side1 + side2 + (Math.Sqrt((side1 * side1) + (side2 * side2))));
    }
    public float GetPerimeter()
    {
        return GetPerimeter(side1, side2);
    }
}

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
    static public float GetSurface(Rectangle rectangle, float height)
    {
        //計算する
        return (rectangle.GetSurface() * 2 + rectangle.GetPerimeter() * height); //表面積を計算し返す 
    }
    static public float GetSurface(float width, float height, float depth)
    {
        //計算する
        //return GetSurface(new Rectangle(width, depth), height);
        return (Rectangle.GetSurface(width, depth) * 2
            + Rectangle.GetPerimeter(width, depth) * height); //表面積を計算し返す 
    }
    public float GetSurface()
    {
        //計算する
        return GetSurface(this.rectangle, this.height); //表面積を計算し返す 
    }
    //体積を取得するメソッドGetVolumeが在る
    static public float GetVolume(Rectangle rectangle, float height)
    {
        return rectangle.GetSurface() * height;   //体積を計算し返す
    }
    static public float GetVolume(float width, float height, float depth)
    {
        return Rectangle.GetSurface(width, height) * depth;   //体積を計算し返す
    }
    public float GetVolume()
    {
        return GetVolume(this.rectangle, this.height);   //体積を計算し返す
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
    static public float GetSurface(Circle circle, float height)
    {
        return (float)(circle.GetSurface() * 2 + circle.GetPerimeter() * height); //表面積を計算し返す 
    }
    static public float GetSurface(float radius, float height)
    {
        return (float)(Circle.GetSurface(radius) * 2 + Circle.GetPerimeter(radius) * height); //表面積を計算し返す 
    }
    public float GetSurface()
    {
        //計算する
        return GetSurface(circle, height); //表面積を計算し返す 
    }
    static public float GetVolume(Circle circle, float height)
    {
        return (float)(circle.GetSurface() * height);   //体積を計算し返す
    }
    static public float GetVolume(float radius, float height)
    {
        return (float)(Circle.GetSurface(radius) * height);   //体積を計算し返す
    }
    public float GetVolume()
    {
        return GetVolume(circle, height);   //体積を計算し返す
    }
}
class Sphere
{
    private float radius;
    public Sphere(float radius)
    {
        this.radius = radius;
    }
    static public float GetSurface(float radius)
    {
        return (float)(radius * radius * Math.PI * 4); //表面積を計算し返す 
    }
    public float GetSurface()
    {
        return GetSurface(radius); //表面積を計算し返す 
    }
    static public float GetVolume(float radius)
    {
        return (float)(radius * radius * radius * Math.PI * 4 / 3);   //体積を計算し返す
    }
    public float GetVolume()
    {
        return GetVolume(radius);   //体積を計算し返す
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
    static public float GetSurface(Triangle triangle, float height)
    {
        return (float)(triangle.GetSurface() * 2
            + triangle.GetPerimeter() * height); //表面積を計算し返す 
    }
    static public float GetSurface(float side1, float side2, float side3, float height)
    {
        return Triangle.GetSurface(side1, side2, side3) * 2
            + Triangle.GetPerimeter(side1, side2, side3) * height; //表面積を計算し返す 
    }
    public float GetSurface()
    {
        return GetSurface(triangle, height); //表面積を計算し返す 
    }
    static public float GetVolume(Triangle triangle, float height)
    {
        return (float)(triangle.GetSurface() * height);   //体積を計算し返す
    }
    static public float GetVolume(float side1, float side2, float side3, float height)
    {
        return (float)(Triangle.GetSurface(side1, side2, side3) * height);   //体積を計算し返す
    }
    public float GetVolume()
    {
        return GetVolume(triangle, height);   //体積を計算し返す
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
    static public float GetSurface(Circle circle, float height)
    {
        double r2 = Math.Sqrt(circle.GetRadius() * circle.GetRadius() + height * height);
        return (float)(circle.GetSurface() + r2 * r2 * Math.PI * circle.GetRadius() / r2);
    }
    static public float GetSurface(float radius, float height)
    {
        double r2 = Math.Sqrt(radius * radius + height * height);
        return (float)(Circle.GetSurface(radius) + r2 * r2 * Math.PI * radius / r2);
    }

    public float GetSurface()
    {
        return GetSurface(circle, height);
    }
    static public float GetVolume(Circle circle, float height)
    {
        return (float)((double)circle.GetSurface() * height / 3);
    }
    static public float GetVolume(float radius, float height)
    {
        return (float)((double)Circle.GetSurface(radius) * height / 3);
    }
    public float GetVolume()
    {
        return GetVolume(circle, height);
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
