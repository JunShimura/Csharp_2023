namespace InheritanceSample2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jun Shimura", 25);
            person.SelfIntroduction();
        }
    }
    /// <summary>
    /// 人物の定義
    /// </summary>
    class Person
    {
        private string name;    //名前
        private int age;        //年齢
        public Person(string name, int age = 0)
        {
            this.name = name;
            this.age = age;
        }
        /// <summary>
        /// 自己紹介
        /// </summary>
        public void SelfIntroduction()
        {
            SelfIntroduction(this);
            //Console.WriteLine($"私の名前は{name}です、年齢は{age}です。");
        }
        /// <summary>
        /// 自己紹介
        /// </summary>
        /// <param name="p">自己紹介する人物</param>
        static public void SelfIntroduction(Person p)
        {
            Console.WriteLine($"私の名前は{p.name}です、年齢は{p.age}です。");
        }
    }
}