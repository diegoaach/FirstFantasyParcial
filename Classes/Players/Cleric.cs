using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes
{
    public class Cleric : Character
    {
        public Cleric() { }

        public Cleric(string name)
        {
            this.Name = name;

        }


        public override string Taunt()
        {
            return "By the ancient gods";
        }

        public override string ShowInformation()
        {
            string text = "Name: " + Name + "\n"
                         + "Type: Cleric \n"
                         + "Armor: " + Armor + "\n"
                         + "Weapon: " + PersonalWeapon + "\n\n";

            return text;
        }
    }
}
