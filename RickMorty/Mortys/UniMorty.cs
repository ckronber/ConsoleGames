using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMorty.Mortys
{
    public class UnicornMorty : IMorty
    {
        public int Health { get; set; } = 2500;
        public void Scream()
        {
            Console.WriteLine("Nehhhhhh");
        }
        public void RandomSpeak()
        {
            Random value = new Random();
            switch(value.Next(0, 6))
            {
                case 0:
                    Console.WriteLine("I am MORTY UNICORN!!!!");
                    break;
                case 1:
                    Console.WriteLine("UNI the unicorn here! Dont cross me >>>>>");
                    break;
                case 2:
                    Console.WriteLine("I'll bite your legs off!");
                    break;
                case 3:
                    Console.WriteLine("Bring out your Dead!");
                    break;
                case 4:
                    Console.WriteLine("She turned me into a NEWT!");
                    break;
                case 5:
                    Console.WriteLine("You want a piece of me!?");
                    break;
                default:
                    Console.WriteLine("I got nothin!");
                    break;
            }
        }
        public void Hurt(Attack attack)
        {
            Health -= attack.Damage;
        }
        public Attack Attack()
        {
            return new Attack(20, 40, DamageType.Piercing, "UniPierce");
        }
    }
}
