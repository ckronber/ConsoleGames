using Birds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public enum CharacterType { Bird, VulnerableHunter, InvincibleHunter }

    public class Birds
    {
        public int _Counter = 0;
        public string Name { get; private set; }
        public int Value { get; private set; }
        public List<string> birdName =  new List<string> {"Bird", "CrestedIbis", "GreatKiskudee", "RedCrossbill", "Red-Necked Phalarope", "Evening Grosbeak", "GreaterPrairieChicken", "IcelandGull", "Orange-BelliedParrot","VulnerableBirdHunter"};
        CharacterType CharType { get; }

        public int ValueMultiplier()
        {
            _Counter = _Counter % 4 + 1;
            int newValue = Convert.ToInt32(Math.Pow(2, _Counter) * 100);
            return newValue;
        }
    }

 }

