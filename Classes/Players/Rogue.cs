using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes
{
    public class Rogue : Character
    {
        public override string Taunt()
        {
            return "By myself";
        }

        public override string ShowInformation()
        {
            string text = "Name: " + Name + "\n"
                         + "Type: Rogue \n"
                         + "Armor: " + Armor + "\n"
                         + "Weapon: " + PersonalWeapon + "\n\n";

            return text;
        }

    }
}
