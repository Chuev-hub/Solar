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

namespace Solar.UI.Views
{
    /// <summary>
    /// Interaction logic for ContactUsPageView.xaml
    /// </summary>
    public partial class ContactUsPageView : UserControl
    {
        public ContactUsPageView()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
          
        }

        private void textbox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if(textbox1.Text =="")
              label2.Visibility = Visibility.Visible;
        }

        private void textbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            label2.Visibility = Visibility.Hidden;
        }

        private void textbox2_GotFocus(object sender, RoutedEventArgs e)
        {
            label3.Visibility = Visibility.Hidden;
        }

        private void textbox2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox2.Text == "")
                label3.Visibility = Visibility.Visible;
        }

        private void textbox3_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textbox3.Text == "")
                label4.Visibility = Visibility.Visible;
        }

        private void textbox3_GotFocus(object sender, RoutedEventArgs e)
        {
            label4.Visibility = Visibility.Hidden;

        }
    }
}
