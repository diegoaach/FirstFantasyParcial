using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasyParcial.Classes.Equipment
{
    public abstract  class Tool
    {
        private string name;

        public virtual string Name { get => name; set => name = value; }

        public abstract string ShowInformation();

        
    }
}
