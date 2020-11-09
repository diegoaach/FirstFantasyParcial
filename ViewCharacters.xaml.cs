using FirstFantasyParcial.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using FirstFantasyParcial.Classes.Equipment;


namespace FirstFantasyParcial
{
    /// <summary>
    /// Lógica de interacción para ViewCharacters.xaml
    /// </summary>
    public partial class ViewCharacters : Page
    {


        public ViewCharacters()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new Start());
        }

        private void btnViewInfo_Click(object sender, RoutedEventArgs e)
        {







        }

        private void btnLoadCharacter_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\Diego\Documents\UPB\II Semestre\Paradigmas de Programacion\Parcial Final Practica\FirstFantasyParcial\Characters.txt";

            string option = cboxCType.Text;
            Character c;

            switch (option)
            {
                case "Cleric":
                    c = new Cleric();
                    c.Type = "Cleric";
                    break;

                case "Fighter":
                    c = new Fighter();
                    c.Type = "Fighter";
                    break;

                case "Rogue":
                    c = new Rogue();
                    c.Type = "Rogue";
                    break;

                case "Wizard":
                    c = new Wizard();
                    c.Type = "Wizard";
                    break;

                default:
                    c = null;
                    MessageBox.Show("You must select a type");
                    break;
            }

            

            using (StreamReader file = new StreamReader(path))
            {
                int index = 0;
                Character[] characters = new Character[index];
                
                while (!file.EndOfStream)
                {
                    c.Name = file.ReadLine();
                    c.Type = file.ReadLine();
                    c.Armor = file.ReadLine();
                    string weapon = file.ReadLine();
                    switch (weapon)
                    {
                        case "Sword":
                            c.PersonalWeapon = new Sword(15);
                            break;
                        case "Axe":
                            c.PersonalWeapon = new Axe(20);
                            break;
                        case "Mace":
                            c.PersonalWeapon = new Mace(30);
                            break;
                    }
                    
                }
                foreach(Character d in characters)
                {
                    cboxViewInfo.Items.Add(d.Name);
                }
                
                




            }




        }
    }
}
