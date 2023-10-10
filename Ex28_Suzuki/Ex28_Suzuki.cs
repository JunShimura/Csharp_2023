namespace Ex28_Suzuki
{
    internal class Ex28_Suzuki
    {
        static void Main(string[] args)
        {
            /*
                       float r = (float)InputUtility.InputNumber("円の半径：", 0.125, 500, "その値はおかしいよ！");
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
           */
            Triangle triangle = new Triangle(
                1, (float)Math.Sqrt(3), 2
                //(float)InputUtility.InputNumber("辺1の長さ："),
                //(float)InputUtility.InputNumber("辺2の長さ："),
                // (float)InputUtility.InputNumber("辺3の長さ：")
                );
            Console.WriteLine($"triangleの面積は{triangle.GetSurface()}、周囲の長さは{triangle.GetPerimeter()}");
            Triangle rightTriangle = new Triangle(
                1, (float)Math.Sqrt(3)
                //(float)InputUtility.InputNumber("直角三角形の底辺の長さ："),
                //(float)InputUtility.InputNumber("直角三角形の高さ：")
                );
            Console.WriteLine($"triangleの面積は{rightTriangle.GetSurface2()}、周囲の長さは{rightTriangle.GetPerimeter2()}");

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

    class Triangle
    {
        private float side1;
        private float side2;
        private float side3;

        //3辺の長さ
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
        public float GetSurface()
        {
            double s = (double)((side1 + side2 + side3) / 2);
            double t = s * (s - side1) * (s - side2) * (s - side3);
            t = Math.Sqrt(t);
            return (float)t;
        }
        public float GetPerimeter()
        {
            return side1 + side2 + side3;
        }

        //2辺の長さ
        public Triangle(float side1, float side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public float GetSurface2()
        {
            return (side1 * side2) / 2;
        }
        public float GetPerimeter2()
        {
            double s = (double)(side1 * side1) + (side2 * side2);
            s = Math.Sqrt(s);
            return (float)s + side1 + side2;
        }
    }

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
                Console.WriteLine("エラー");
            }
            return i;
        }
    }
}