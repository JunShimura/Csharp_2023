using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2);
            Character character2 = new Character("ささっき", 1000, 25);
            character2.Attack(character1);
            character1.Attack(character2);
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Character[] characters = { character2, tank1, tank2 };
            foreach(Character attacker in characters)
            {
                attacker.Attack(character1);
            }
        }
    }
}
