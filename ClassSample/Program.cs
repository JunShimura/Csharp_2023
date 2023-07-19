using System.Runtime.CompilerServices;

namespace ClassSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassSampleA classSampleA = new ClassSampleA(4, 8);
            var c = classSampleA.Func();
            classSampleA.b = -5;
            Vector3 vector0 = new Vector3(2, 2, 1);
            Vector3 vector1 = new Vector3();
            var m = vector0.GetMagnitude();
        }
    }

    class ClassSampleA   //　Classの宣言
    {
        private int a = 3;
        public int b = 5;

        public ClassSampleA(int a = 0, int b = 0)   // コンストラクタ
        {
            this.a = a;
            this.b = b;
        }
        public int Func()
        {
            return a + b;
        }
    }
    class Vector3
    {
        // X component of the vector.
        public float x;
        // Y component of the vector.
        public float y;
        // Z component of the vector.
        public float z;
        public Vector3(float x = 0, float y = 0, float z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float GetMagnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
    }

}