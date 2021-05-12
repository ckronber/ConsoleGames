using RickMorty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMorty.Mortys
{
    public class WerewolfMorty:IMorty
    {
        public int Health { get; set; } = 25;
        public void Scream()
        {
            Console.WriteLine("RAWWWOOOOOoooOOOoooowwww");
        }
        public void Hurt(Attack attack)
        {
            if(attack.Type == DamageType.Piercing || attack.Type == DamageType.Shocking)
                Health -= (int)Math.Floor(attack.Damage * 1.5);
            else if(attack.Type == DamageType.Bludgeoning || attack.Type == DamageType.Psych)
                Health -= (int)Math.Ceiling(attack.Damage * 0.5);
            else
                Health -= attack.Damage;
        }
        public Attack Attack()
        {
            return new Attack(5, 10, DamageType.Slashing, "Paw Slap");
        }
    }
}
