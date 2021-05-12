using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMorty
{
    public enum DamageType { Bludgeoning, Slashing, Piercing, Poison, Acid, Sonic, Psych, Fire, Water, Ice, Shocking, Magic, Necrotic, Radiant };
    public class Attack
    {
        public int Damage;
        public DamageType Type;
        public string Name { get; set;}
        private readonly Random rand = new Random();

        public Attack(int minDamage, int maxDamage, DamageType type, string name)
        {
            this.Type = type;
            this.Damage = rand.Next(minDamage, maxDamage + 1);
            this.Name = name;
        }


    }
}
