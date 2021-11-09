using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var allegience1 = new Allegience()
            {
                _allegienceName = "Chaos"
            };

            var weapon1 = new Weapon()
            {
                _weaponRange = 1,
                _weaponAttacks = 3,
                _weaponStrength = 3,
                _weaponWounds = 1
            };

            var class1 = new Class()
            {
                _className = "Warrior"
            };

            var race1 = new Race()
            {
                _raceName = "Human"
            };

            var fighter1 = new Fighter()
            {
                _fighterName = "Havoc",
                _fighterAlligence = allegience1,
                _fighterClass = class1,
                _fighterRace = race1,
                _fighterPointCost = 60,
                _fighterMovement = 4,
                _fighterToughness = 3,
                _fighterWounds = 10,
                _fighterWeapon = weapon1

            };


            var fighter2 = new Fighter()
            {
                _fighterName = "Veruc",
                _fighterAlligence = allegience1,
                _fighterClass = class1,
                _fighterRace = race1,
                _fighterPointCost = 55,
                _fighterMovement = 4,
                _fighterToughness = 3,
                _fighterWounds = 10,
                _fighterWeapon = weapon1
            };

            
            Console.WriteLine(fighter2._fighterWounds);
            bool playing = true;
            while (playing)
            {
                bool fighting = true; 
                

                while (fighting)
                {
                    string input = Console.ReadLine();
                    if (input.ToUpper() == "ATTACK")
                    {
                        fighter1.attack(fighter2);
                        fighter2.attack(fighter1);
                    }
                }
            }
        }
    }
}
