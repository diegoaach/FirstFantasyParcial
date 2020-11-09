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
        List<Character> character = new List<Character>;


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
            string path = 
            FileManager.ReadAllLines()
            {
                
            } 
            









        }

      
                




            




        
    }
}
