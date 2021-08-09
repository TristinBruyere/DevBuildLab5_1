
using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public virtual void Play()
        {
            Console.WriteLine($"The character, {Name}, has a strength of {Strength} and an intelligence level of {Intelligence}.\n");
        }

        public GameCharacter(string _name, int _strength, int _intelligence)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
        }

    }
    class Warrior : GameCharacter
    {
        
        private string weaponType;
        public string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }

        public Warrior(string _name, int _strength, int _intelligence, string _weaponType) : base(_name, _strength, _intelligence)
        {
            WeaponType = _weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"The warrior, {Name}, uses a {WeaponType} as a weapon. They have a strength level of {Strength} and an intelligence level of {Intelligence}.\n");
        }
    }
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy;

        public MagicUsingCharacter(string _name, int _strength, int _intelligence, int _magicalEnergy) : base(_name, _strength, _intelligence)
        {
            MagicalEnergy = _magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"The magic user, {Name}, has {MagicalEnergy} points of magical energy. They have a strength level of {Strength} and an intelligence level of {Intelligence}.\n");
        }
    }
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;
        public int SpellNumber 
        { 
        get { return spellNumber; }
        set { spellNumber = value; }
        }

        public Wizard(string _name, int _strength, int _intelligence, int _magicalEnergy, int _spellNumber) : base(_name, _strength, _intelligence, _magicalEnergy)
        {
            SpellNumber = _spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"The wizard, {Name}, has {SpellNumber} spells, and {MagicalEnergy} points of magical energy. They have a strength level of {Strength} and an intelligence level of {Intelligence}.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            // Warrior war1 = new Warrior { Name = "Master Yi", Strength = 18, Intelligence = 0, WeaponType = "Katana" };
            Warrior war1 = new Warrior("Master Yi", 18, 0, "Katana");
            gameCharacters.Add(war1);
            war1 = new Warrior ("Poppy", 14, 4, "Hammer" );
            gameCharacters.Add(war1);

            Wizard wiz1 = new Wizard( "Lux", 0, 18, 100, 4 );
            gameCharacters.Add(wiz1);
            wiz1 = new Wizard ( "Viegar", 4, 14, 80, 5 );
            gameCharacters.Add(wiz1);
            wiz1 = new Wizard ( "Vel'Koz", 2, 16, 60, 6 );
            gameCharacters.Add(wiz1);

            Console.WriteLine("***Welcome to Summoners Rift***\n");

            foreach (GameCharacter player in gameCharacters)
            {
                player.Play();
            }
;
        }
    }
}
