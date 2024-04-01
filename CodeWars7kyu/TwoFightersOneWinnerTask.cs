using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TwoFightersOneWinnerTask
    {
        public class Fighter
        {
            public string Name;
            public int Health, DamagePerAttack;
            public Fighter(string name, int health, int damagePerAttack)
            {
                this.Name = name;
                this.Health = health;
                this.DamagePerAttack = damagePerAttack;
            }
        }
        public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            while (fighter1.Health > 0 && fighter2.Health > 0)
            {
                if (firstAttacker == fighter1.Name)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                    {
                        return fighter1.Name;
                    }
                    fighter1.Health -= fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                    {
                        return fighter2.Name;
                    }
                }
                else if (firstAttacker == fighter2.Name)
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                    {
                        return fighter2.Name;
                    }
                    fighter2.Health -= fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                    {
                        return fighter1.Name;
                    }
                }
            }

            return "";
        }
    }
}
//https://www.codewars.com/kata/577bd8d4ae2807c64b00045b/train/csharp