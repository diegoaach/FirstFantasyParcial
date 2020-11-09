using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasyParcial.Classes
{
    class FileManager
    {
        
        public static void AddCharacter(Character c)
        {
            string path = @"C:\Users\Diego\Documents\UPB\II Semestre\Paradigmas de Programacion\Parcial Final Practica\FirstFantasyParcial\Characters.txt";
            
            
            File.AppendAllText(path, "\n\n" + string.Format("{0}\n{1}\n{2}\n{3}", 
                                                            c.Name, c.Type, c.Armor, c.PersonalWeapon.ShowInformation()));
            
            
        }
        public static String[] ReadAllLines()
        {
            string path = @"C:\Users\Diego\Documents\UPB\II Semestre\Paradigmas de Programacion\Parcial Final Practica\FirstFantasyParcial\Characters.txt";
            if (File.Exists(path))
            {
                string[] allLines = File.ReadAllLines(path);
                return allLines;
            }
            else
            {
                return null;
            }
        }

      


        


    }
}
