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

            File.AppendAllText(path, "\n" + c.ToString());
        }
    }
}
