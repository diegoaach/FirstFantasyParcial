using FirstFantasyParcial.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using FirstFantasyParcial.Classes.Equipment;

namespace FirstFantasyParcial.Classes
{
    public abstract partial class Character : IDescribable

    {
        private string name;
        private int level;
        private int experience;
        private List<Tool> bag;
        private string armor;

       

        

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        protected Character()
        {
            this.Level = 1;
            this.Experience = 1;
        }

        public int Experience { get => experience; set => experience = value; }
       
        public List<Tool> Bag { get => bag; set => bag = value; }
        public string Armor { get => armor; set => armor = value; }

        public abstract String Taunt();

        protected Character(List<Tool> bag)
        {
            this.bag = bag;
        }

       

        public string ShowInformation()
        {
            string text = "This is a level " + Level + " character";

            foreach(Tool t in bag)
            {
                text += "\n"+t.ShowInformation();
                
            }
            return text;
        }
    }
}
