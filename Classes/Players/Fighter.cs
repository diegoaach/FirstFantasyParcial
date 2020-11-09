using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes
{
    public class Fighter : Character
    {
        public override string Taunt()
        {
            return "By my sacred Lord";
        }

        public override string ShowInformation()
        {
            string text = "Name: " + Name + "\n"
                         + "Type: Fighter \n"
                         + "Armor: " + Armor + "\n"
                         + "Weapon: " + PersonalWeapon + "\n\n";

            return text;
        }

       
        
    }
}
