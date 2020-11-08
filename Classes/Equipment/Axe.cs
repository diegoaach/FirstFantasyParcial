using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes.Equipment
{
    public class Axe : Weapon

    {
        public Axe(int damage) : base(damage)
        {
        }

        public override string ShowInformation()
        {
            return "This is an axe with " + Damage + " points of damage";
        }
    }
}
