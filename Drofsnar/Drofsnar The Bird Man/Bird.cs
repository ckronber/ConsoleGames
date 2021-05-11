using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    //public enum CharacterType { Bird, VulnerableHunter, InvincibleHunter }

    public interface IBird
    {
        string Name { get; }
        int Value { get; }
        CharacterType CharType { get; }
    }

    public class Bird : IBird
    {
        public string Name => "Bird";
        public int Value => 10;
        public CharacterType CharType => CharacterType.Bird;
    }

    public class CrestedIbis : IBird
    {
        public string Name => "CrestedIbis";
        public int Value => 100;
        public CharacterType CharType => CharacterType.Bird;
    }

    public class GreatKiskudee : IBird
    {
        public string Name => "GreatKiskudee";
        public int Value => 300;
        public CharacterType CharType => CharacterType.Bird;
    }

    public class RedCrossbill : IBird
    {
        public string Name => "RedCrossbill";
        public int Value => 500;
        public CharacterType CharType => CharacterType.Bird;
    }

    public class RedNeckedPhalarope : IBird
    {
        public string Name => "Red-neckedPhalarope";
        public int Value => 700;
        public CharacterType CharType => CharacterType.Bird;
    }

    public class EveningGrosbeak : IBird
    {
        public string Name => "EveningGrosbeak";
        public int Value => 1000;
        public CharacterType CharType => CharacterType.Bird;
    }

    public class GreaterPrarieChicken : IBird
    {
        public string Name => "GreaterPrarieChicken";
        public int Value => 2000;
        public CharacterType CharType => CharacterType.Bird;
    }

    public class IcelandGull : IBird
    {
        public string Name => "IcelandGull";
        public int Value => 3000;
        public CharacterType CharType => CharacterType.Bird;

    }

    public class OrangeBelliedParrot : IBird
    {
        public string Name => "Orange-belliedParrot";
        public int Value => 5000;
        public CharacterType CharType => CharacterType.Bird;

    }

    public class VulnerableBirdHunter : IBird
    {
        public string Name => "VulnerableBirdHunter";
        public int Value => 200;
        public int _Counter = 0;
        public CharacterType CharType => CharacterType.VulnerableHunter;

        //method for returning the score
        public int ValueMultiplier()
        {
            _Counter = _Counter % 4 + 1;
            int newValue = Convert.ToInt32(Math.Pow(2, _Counter) * 100);
            return newValue;
        }
    }

    public class InvincibleBirdHunter : IBird
    {
        public string Name => "InvincibleBirdHunter";
        public int Value => 0;
        public CharacterType CharType => CharacterType.InvincibleHunter;
    }
}