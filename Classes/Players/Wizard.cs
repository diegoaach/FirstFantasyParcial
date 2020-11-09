using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes
{
    public class Wizard : Character
    {
        

        public override string Taunt()
        {
            return "By the master spells";
        }

        public override string ShowInformation()
        {
            string text = "Name: " + Name + "\n"
                         + "Type: Wizard \n"
                         + "Armor: " + Armor + "\n"
                         + "Weapon: " + PersonalWeapon + "\n\n";

            return text;
        }




    }
}
