using FirstFantasyParcial.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes
{
    public class Sword : Weapon
    {
        public Sword(int damage) : base(damage)
        {
        }

        public override string ShowInformation()
        {
            return "This is a sword with "+Damage+" points of damage";
        }

        
    }
}
