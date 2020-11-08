using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes
{
    public class Wizard : Character
    {
        private int mp;

        public int Mp { get => mp; set => mp = value; }

        public override string Taunt()
        {
            return "By the master spells";
        }

        public string CastSpell()
        {
            return "KAAAABOOM";
        }

    }
}
