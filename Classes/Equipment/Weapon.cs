using FirstFantasyParcial.Classes.Equipment;
using FirstFantasyParcial.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes
{
    public abstract class Weapon : Tool, IDescribable, IComparable<Weapon>

    {
        

        private int damage;
       
        private string name;


        public int Damage { get => damage; set => damage = value; }
        
        
        public override string Name { get => name; set => name = value; }



        protected Weapon(int damage)
        {
            this.damage = damage;
        }

        public string Attack()
        {
            return "Attack!";
        }
        public string Attack(int times)
        {
            string message = "";

            for (int i = 0; i < times; i++)
            {
                message += Attack() + " ";

            }
            return message; 
        }

        public abstract override string ShowInformation();


        

        public int CompareTo(Weapon obj)
        {
            return damage.CompareTo(obj.damage);
        }
         
            
      
    }
}
