using System;
using System.Collections.Generic;
using System.Text;
using FirstFantasyParcial.Classes.Equipment;
using FirstFantasyParcial.Interfaces;

namespace FirstFantasyParcial.Classes
{
    public class Potion : Tool, IDescribable
    {
        public enum Spells { Heal};
        private Spells spell;
        private string name;



        
        public Spells Spell { get => spell; set => spell = value; }
        public override string Name { get => name; set => name = value; }

        public Potion()
        {
            
        }

        public override string ShowInformation()
        {
            return "This is a strange potion";
        }

        
    }
}
