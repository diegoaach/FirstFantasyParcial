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
using FirstFantasyParcial.Classes;
using FirstFantasyParcial.Classes.Equipment;
using FirstFantasyParcial.Interfaces;



namespace FirstFantasyParcial
{
    /// <summary>
    /// Lógica de interacción para CreateCharacter.xaml
    /// </summary>
    public partial class CreateCharacter : Page
    {

        List<Character> list = new List<Character>();

        


        public CreateCharacter()
        {
            InitializeComponent();
        }



        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new Start());

        }

        private void btnSaveCharacter_Click(object sender, RoutedEventArgs e)
        {
            Character c;
            string option = cboxType.Text;

            switch(option)
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

            c.Name = txtCharacterName.Text;
            c.Armor = cboxArmor.Text;

            string weapon = cboxFirstWeapon.Text;

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
                default:
                    c.PersonalWeapon = null;
                    MessageBox.Show("Please select your weapon.");
                    break;
            } 
            if (c != null)
            {
                list.Add(c);
                FileManager.AddCharacter(list);
            }

            txtCharacterName.Text = "";
            cboxArmor.SelectedItem = null;
            cboxFirstWeapon.SelectedItem = null;
            cboxType.SelectedItem = null;












        }


       


                
    }
}
