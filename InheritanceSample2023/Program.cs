namespace InheritanceSample2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons
            = {
                new Person("Jun Shimura", new DateTime(2001,6,2)),      // 生年月日 updated 20231205
                new Student("Riku Sawamura", new DateTime(2004,7,18),"デジタルアーツ仙台",6), // 生年月日 updated 20231205
                new Worker("Utaro Seki",new DateTime(1997,8,28),"Seki corporation", 10000000)
            };
            foreach (Person person in persons)
            {
                person.SelfIntroduction();
            }
            //個別で自己紹介
            Console.WriteLine("***個別で自己紹介***");
            Student sawamura = (Student)persons[1];
            sawamura.SelfIntroduction();
            Worker seki = (Worker)persons[2];
            seki.SelfIntroduction();
        }
    }
    /// <summary>
    /// 人物の定義
    /// </summary>
    class Person
    {
        private string name;    //名前
        private readonly DateTime birthday;             // 生年月日 updated 20231205
        public Person(string name, DateTime birthday)   // 生年月日 updated 20231205
        {
            this.name = name;
            this.birthday = birthday;                   // 生年月日 updated 20231205
        }
        /// <summary>
        /// 自己紹介
        /// </summary>
        public virtual void SelfIntroduction()
        {
            SelfIntroduction(this);
        }
        /// <summary>
        /// 自己紹介
        /// </summary>
        /// <param name="p">自己紹介する人物</param>
        static public void SelfIntroduction(Person p)
        {
            Console.WriteLine($"私の名前は{p.name}です。");
            Console.WriteLine($"誕生日は{p.birthday.ToString("yyyy/M/d")}です。");// 生年月日 updated 20231205
        }
    }

    /// <summary>
    /// 団体に属している人
    /// </summary>
    class Member : Person
    {
        public string organization; // 所属団体
        public Member(string name, DateTime birthday, string organization) : base(name, birthday)
        {
            this.organization = organization;
        }
        public override void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"所属する団体は{this.organization}です。");
        }
    }

    class Student : Member
    {
        private int id;  // 学籍番号
        public Student(string name, DateTime birthday, string organization, int id = 0)
            : base(name, birthday, organization)// 生年月日 updated 20231205
        {
            this.id = id;
        }
        public override void SelfIntroduction()  //学生さんの自己紹介
        {
            base.SelfIntroduction();    // 親のメソッドを呼ぶ
            Console.WriteLine($"学籍番号は{this.id}です。");
        }
    }
    class Worker : Member
    {
        private int income; // 収入
        public Worker(string name, DateTime birthday, string organization, int income = 0)
            : base(name, birthday,organization)
        {
            this.income = income;
        }
        public override void SelfIntroduction()  //学生さんの自己紹介
        {
            base.SelfIntroduction();    // 親のメソッドを呼ぶ
            Console.WriteLine($"収入は{this.income}円です。");
        }
    }
}