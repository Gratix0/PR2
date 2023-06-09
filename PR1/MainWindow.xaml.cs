﻿using System;
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
using PR1.PostOfficeDataSetTableAdapters;

namespace PR1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OfficeTableAdapter Office = new OfficeTableAdapter();
        produktTableAdapter Product = new produktTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            AllDataO.ItemsSource = Office.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Office.InsertQuery(NameTbx.Text);
            AllDataO.ItemsSource = Office.GetData();
        }
    }
}
