using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class Fighter
    {
        public Allegience _fighterAlligence { get; set; }
        public string _fighterName { get; set; }
        public Class _fighterClass { get; set; }
        public Race _fighterRace { get; set; }
        public int _fighterPointCost { get; set; }
        public int _fighterMovement { get; set; }
        public int _fighterToughness { get; set; }
        public int _fighterWounds { get; set; }

        public Weapon _fighterWeapon { get; set; }

        public void attack(Fighter opponent)
        {
            Random rand = new Random();
            int diceThrow = rand.Next(1,7);
            if (opponent._fighterWounds == 0)
            {
                Console.WriteLine("The opponent is dead and cannot fight");
            }else if (this._fighterWounds == 0)
            {
                Console.WriteLine($"{this._fighterName} is dead and cannot fight");
            }
            else if (this._fighterWeapon._weaponStrength > opponent._fighterToughness && diceThrow >= opponent._fighterToughness)
            {          
                looseHp(opponent, this);
            }
            else if(this._fighterWeapon._weaponStrength == opponent._fighterToughness && diceThrow > opponent._fighterToughness)
            {
                looseHp(opponent, this);
            }
            else if(this._fighterWeapon._weaponStrength < opponent._fighterToughness && diceThrow >= 5)
            {
                looseHp(opponent, this);
            }
            else
            {
                Console.WriteLine($"{this._fighterName} missed!");
            }
            Console.WriteLine(diceThrow);



        }

        public void looseHp(Fighter defender, Fighter attacker)
        {
            defender._fighterWounds -= attacker._fighterWeapon._weaponWounds;
            Console.WriteLine($"{attacker._fighterName} hit {defender._fighterName} for " + attacker._fighterWeapon._weaponWounds + $". {defender._fighterName} has " + defender._fighterWounds + " HP left");
        }
    }
}
