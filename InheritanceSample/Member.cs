using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSampleSuraSura
{
    class Member:Person
    {
        public string organization;
        public Member(string name, int age = 0,string organization=null) : base(name, age)
        {
            this.organization = organization;
        }
        new public void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"所属団体は{organization}です。");
        }
    }
}
