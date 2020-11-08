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
            string option = cboxType.Text;

            Character c;

            switch (option)
            {
                case "Cleric":
                    c = new Cleric();
                    break;

                case "Fighter":
                    c = new Fighter();
                    break;

                case "Rogue":
                    c = new Rogue();
                    break;

                case "Wizard":
                    c = new Wizard();
                    break;

                default:
                    c = null;
                    MessageBox.Show("You must select a type");
                    break;
            }
            c.Name = txtCharacterName.Text;
            c.Level = 1;
            c.Armor = cboxArmor.Text;



        }

        
    }
}
