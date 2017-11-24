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

namespace _02.Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Imige = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnButton1_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton2_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton3_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton4_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton5_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton6_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton7_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton8_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void btnButton9_Click(object sender, RoutedEventArgs e)
        {
            if (Imige == false)
            {
                Content = "X";
                Imige = true;
            }
            else if (Imige == true)
            {
                Content = "O";
                Imige = false;
            }
            Winner();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            btnButton1.Content = "";
            btnButton2.Content = "";
            btnButton3.Content = "";
            btnButton4.Content = "";
            btnButton5.Content = "";
            btnButton6.Content = "";
            btnButton7.Content = "";
            btnButton8.Content = "";
            btnButton9.Content = "";
        }

        public void Winner()
        {
            if(btnButton1.Content == "X" && btnButton2.Content == "X" && btnButton3.Content == "X" || btnButton4.Content == "X" && btnButton5.Content == "X" && btnButton6.Content == "X" || btnButton7.Content == "X" && btnButton8.Content == "X" && btnButton9.Content == "X" || btnButton1.Content == "X" && btnButton4.Content == "X" && btnButton7.Content == "X" || btnButton2.Content == "X" && btnButton5.Content == "X" && btnButton8.Content == "X" || btnButton3.Content == "X" && btnButton6.Content == "X" && btnButton9.Content == "X" || btnButton1.Content == "X" && btnButton5.Content == "X" && btnButton9.Content == "X" || btnButton3.Content == "X" && btnButton5.Content == "X" && btnButton7.Content == "X")
            {
                MessageBox.Show("X heeft gewonnen", "gefeliciteerd");
                Button_Click(null, null);
            }
            else if (btnButton1.Content == "O" && btnButton2.Content == "O" && btnButton3.Content == "O" || btnButton4.Content == "O" && btnButton5.Content == "O" && btnButton6.Content == "O" || btnButton7.Content == "O" && btnButton8.Content == "O" && btnButton9.Content == "O" || btnButton1.Content == "O" && btnButton4.Content == "O" && btnButton7.Content == "O" || btnButton2.Content == "O" && btnButton5.Content == "O" && btnButton8.Content == "O" || btnButton3.Content == "O" && btnButton6.Content == "O" && btnButton9.Content == "O" || btnButton1.Content == "O" && btnButton5.Content == "O" && btnButton9.Content == "O" || btnButton3.Content == "O" && btnButton5.Content == "O" && btnButton7.Content == "O")
            {
                MessageBox.Show("O heeft gewonnen", "gefeliciteerd");
                Button_Click(null, null);
            }
        }
    }
}
