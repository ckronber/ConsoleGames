using Bird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Drofsnar
    {
        //properties
        public string Name = "Drofsnar";
        public int Points = 5000;
        public int Lives = 3;
        public bool GainedExtraLife = false;

        //methods
        public void Encounter(IBird character)
        {
            if (character.CharType == CharacterType.InvincibleHunter)
            {
                Lives--;
                Console.WriteLine("You lost a life.");
            }
            else if (character.CharType == CharacterType.VulnerableHunter)
            {
                VulnerableBirdHunter newVBH = new VulnerableBirdHunter();
                Points += newVBH.ValueMultiplier();
            }
            else
            {
                Points += character.Value;
            }

            if (Points >= 10000 && GainedExtraLife == false)
            {
                Lives++;
                GainedExtraLife = true;
                Console.WriteLine("You gained a life!");
            }
        }
    }
}
