using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace StudentManagerApplication.Views
{
    public partial class EditStudentWindow : Window
    {
        public EditStudentWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}