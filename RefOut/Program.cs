namespace RefOut;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 100;
        Console.Write($"Test a={a} → ");
        Test(a);
        Console.WriteLine($"{a}");
        
 /*       Console.Write($"TestReturn a={a} → ");
        a=TestReturn(a);
        Console.WriteLine($"{a}");*/

        Console.Write($"TestRef a={a} → ");
        TestRef(ref a);
        Console.WriteLine($"{a}");

        /*
        int b = 1;  //　初期化していない
                    //Console.Write($"b={b} → ");   //初期化前で存在しないのでエラー
        TestOut(out b);
        Console.WriteLine($"{b}");
        */
    }
    static void Test(int a)
    {
        a = 10; // メソッド内で値を書き換える
    }
    static int TestReturn(int a)
    {
        a = 10; // メソッド内で値を書き換える
        return a;
    }
    static void TestRef(ref int a)  //aへの参照（場所）を渡されている
    {
        a = 10; // メソッド内で値を書き換える
    }
    static void TestOut(out int a)
    {
        a = 10; // メソッド内で値を書き換える
    }
}
