using FirstFantasyParcial.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using FirstFantasyParcial.Classes.Equipment;

namespace FirstFantasyParcial.Classes
{
    public partial class Character : IDescribable

    {
        private string name;
        private int level;
        private int experience;
        
        private string armor;
        private Weapon personalWeapon;
        private string type;

       

        

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        protected Character()
        {
            this.Level = 1;
            this.Experience = 1;
        }

        
        

        public int Experience { get => experience; set => experience = value; }
       
       
        public string Armor { get => armor; set => armor = value; }
        
        public string Type { get => type; set => type = value; }
        public Weapon PersonalWeapon { get => personalWeapon; set => personalWeapon = value; }

        public abstract String Taunt();

      

        public abstract string ShowInformation();
        
            

            
        
    }
}
