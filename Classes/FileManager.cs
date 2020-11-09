using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasyParcial.Classes
{
    class FileManager
    {
        
        public static void AddCharacter(List<Character> list)
        {
            string path = @"C:\Users\Diego\Documents\UPB\II Semestre\Paradigmas de Programacion\Parcial Final Practica\FirstFantasyParcial\Characters.txt";
            foreach (Character c in list)
            {
                File.AppendAllText(path, "\n\n" + string.Format("Name: {0} - Type: {1} - Armor: {2} - Weapon: {3}", c.Name, c.Type, c.Armor, c.PersonalWeapon.ShowInformation()));
            }
            
        }
    }
}
