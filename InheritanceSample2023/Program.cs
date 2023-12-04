namespace InheritanceSample2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons 
            = { 
                new Person("Jun Shimura", new DateTime(2001,12,10)), 
                new Student("Riku Sawamura", new DateTime(2001,12,10),6)
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
        private readonly DateTime birthday;  // 生年月日
        public Person(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
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
            Console.WriteLine($"私の名前は{p.name}です、誕生日は{p.birthday}です。");
        }
    }
    class Student : Person
    {
        private int id;  // 学籍番号
        public Student(string name, DateTime birthday, int id = 0) : base(name, birthday)
        {
            this.id = id;
        }
    }
}