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

namespace Guess_the_number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        public int RandomNumber { get; set; }
        public int Number { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            NextRand();
        }

        public void NextRand()
        {
            RandomNumber = rand.Next(0, 10);
            Lable_Check_Nubmer.Content = RandomNumber.ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult;
            if (RandomNumber.ToString() == Text_Rand_Number.Text)
            {
                string messageBoxText = "Попробывать еще раз";
                string caption = "Угадал";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Information;
                messageBoxResult = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Cancel);
            }
            else
            {
                string messageBoxText = "Попробывать еще раз";
                string caption = "Не угадал";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Hand;
                messageBoxResult = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Cancel);
            }

            if (messageBoxResult == MessageBoxResult.No)
            {
                Environment.Exit(0);
            }
            NextRand();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
