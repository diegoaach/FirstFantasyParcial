using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /*
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {



            // String option = cboxCharacter.Text;
            /*
            Sword s = new Sword();


            txtOutput.Text= s.Attack(8);

            */

            /*
            List<IDescribable> objectList = new List<IDescribable>();

            objectList.Add(new Axe());
            objectList.Add(new Potion());
            objectList.Add(new Wizard { Level = 10});
            
            foreach(IDescribable d in objectList)
            {
                txtOutput.Text += d.ShowInformation()+" \n";
            }




            */


            /*

            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric();
                    break;

                case "Fighter":
                    myCharacter = new Fighter();
                    break;

                case "Rogue":
                    myCharacter = new Rogue();
                    break;

                case "Wizard":
                    myCharacter = new Wizard();
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You must select a type");
                    break;
            }

            myCharacter.Name = txtNameCharacter.Text;
            myCharacter.Level = 1;
            myCharacter.Experience = 1;




            if (myCharacter != null)
            {
                
                txtOutput.Text = myCharacter.ShowCharacter();
            }

            */


            /*

            List<Weapon> weapons = new List<Weapon>();

            weapons.Add(new Axe(15));
            weapons.Add(new Sword(18));
            weapons.Add(new Axe(5 ));

            foreach(Weapon d in weapons)
            {
                txtOutput.Text += d.ShowInformation() + "\n";
            }
            txtOutput.Text += "\n\n";

            weapons.Sort();

            foreach (Weapon d in weapons)
            {
                txtOutput.Text += d.ShowInformation() + "\n";
            }

            */
            /*
            Character c = new Cleric();
            c.Race = Character.Races.Dwarf.ToString();

            txtOutput.Text = c.Race
            */
        

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Start());
        }
    }
}
