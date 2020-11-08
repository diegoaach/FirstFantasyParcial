using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes.Equipment
{
    public class Mace : Weapon
    {
        public Mace(int damage) : base(damage)
        {
        }

        public override string ShowInformation()
        {
            return "This is a mace with "+Damage+" points of damage";
        }
    }
}
