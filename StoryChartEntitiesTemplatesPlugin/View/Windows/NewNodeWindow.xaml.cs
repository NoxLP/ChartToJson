﻿using StoryChart.ViewModel;
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
using System.Windows.Shapes;

namespace StoryChart.View.Windows
{
    /// <summary>
    /// Lógica de interacción para NewNodeWindow.xaml
    /// </summary>
    public partial class NewNodeWindow : Window
    {
        public NewNodeWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ((NewNodeWindowVM)DataContext).OnWindowLoaded(this);
        }
    }
}
