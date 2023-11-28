namespace InheritanceSample2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons 
            = { 
                new Person("Jun Shimura", 25), 
                new Student("Riku Sawamura", 19,6)
            };
            foreach (Person person in persons)
            {
                person.SelfIntroduction();
            }
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
    class Student : Person
    {
        private int id;  // 学籍番号
        public Student(string name, int age = 0, int id = 0) : base(name, age)
        {
            this.id = id;
        }
    }
}