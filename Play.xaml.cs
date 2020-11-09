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

namespace FirstFantasyParcial
{
    /// <summary>
    /// Lógica de interacción para Play.xaml
    /// </summary>
    public partial class Play : Page
    {
        Character c = new Fighter();
        

        public Play()
        {
            InitializeComponent();

            c.Name = "Diego";
            c.PersonalWeapon = new Sword(5);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new Start());
        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int times = rd.Next(1, 8);

            c.PersonalWeapon.Attack(times);
            int totalDamage = times * c.PersonalWeapon.Damage;

            barEnemyHealth.Value = barEnemyHealth.Value - totalDamage;

            if (barEnemyHealth.Value <= 0)
            {
                MessageBox.Show("You defeated your enemy");
                btnAttack.IsEnabled = false;
            }

        }
    }
}
