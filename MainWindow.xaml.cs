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

namespace asrorov
{
 
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            private void ChangeBackgroundColor(object sender, RoutedEventArgs e)
            {
                mainGrid.Background = mainGrid.Background == System.Windows.Media.Brushes.White ?
                    System.Windows.Media.Brushes.LightBlue :
                    System.Windows.Media.Brushes.White;
                statusText.Text = "Цвет фона изменен";
            }

            private void ShowDeveloperInfo(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Разработчик: Асроров Бахтовар", "Информация о разработчике");
            }

            private void CloseWindow(object sender, RoutedEventArgs e)
            {
                this.Close();
            }

            private void Button_MouseEnter(object sender, MouseEventArgs e)
            {
                if (sender is Button button)
                {
                    statusText.Text = button.ToolTip.ToString();
                }
            }

            private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
            {
                if (sender is MenuItem menuItem)
                {
                    statusText.Text = menuItem.ToolTip.ToString();
                }
            }
        }
    }
