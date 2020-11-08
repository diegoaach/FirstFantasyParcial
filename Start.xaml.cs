﻿using System;
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

namespace FirstFantasyParcial
{
    /// <summary>
    /// Lógica de interacción para Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new CreateCharacter());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new ViewCharacters());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new Play());
        }
    }
}
