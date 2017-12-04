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
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool Imige = false;
        int Xwins = 0;
        int Owins = 0;

        public void btnButton1_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton1.Content == "")
            {
                if (Imige == false)
                {
                    btnButton1.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton1.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton2_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton2.Content == "")
            {
                if (Imige == false)
                {
                    btnButton2.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton2.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton3_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton3.Content == "")
            {
                if (Imige == false)
                {
                    btnButton3.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton3.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton4_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton4.Content == "")
            {
                if (Imige == false)
                {
                    btnButton4.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton4.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton5_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton5.Content == "")
            {
                if (Imige == false)
                {
                    btnButton5.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton5.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton6_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton6.Content == "")
            {
                if (Imige == false)
                {
                    btnButton6.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton6.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton7_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton7.Content == "")
            {
                if (Imige == false)
                {
                    btnButton7.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton7.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton8_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton8.Content == "")
            {
                if (Imige == false)
                {
                    btnButton8.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton8.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void btnButton9_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btnButton9.Content == "")
            {
                if (Imige == false)
                {
                    btnButton9.Content = "X";
                    txtPlayerTurn.Text = "Player turn: O";
                    Imige = true;
                }
                else if (Imige == true)
                {
                    btnButton9.Content = "O";
                    txtPlayerTurn.Text = "Player turn: X";
                    Imige = false;
                }
                check();
            }
        }

        public void check()
        {
            Winner();
            XorOwins();
        }

        public void XorOwins()
        {
            txtNumberWins.Text = "O wins: " + Owins + " / X wins: " + Xwins;
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
            if ((string)btnButton1.Content == "X" && (string)btnButton2.Content == "X" && (string)btnButton3.Content == "X" || (string)btnButton4.Content == "X" && (string)btnButton5.Content == "X" && (string)btnButton6.Content == "X" || (string)btnButton7.Content == "X" && (string)btnButton8.Content == "X" && (string)btnButton9.Content == "X" || (string)btnButton1.Content == "X" && (string)btnButton4.Content == "X" && (string)btnButton7.Content == "X" || (string)btnButton2.Content == "X" && (string)btnButton5.Content == "X" && (string)btnButton8.Content == "X" || (string)btnButton3.Content == "X" && (string)btnButton6.Content == "X" && (string)btnButton9.Content == "X" || (string)btnButton1.Content == "X" && (string)btnButton5.Content == "X" && (string)btnButton9.Content == "X" || (string)btnButton3.Content == "X" && (string)btnButton5.Content == "X" && (string)btnButton7.Content == "X")
            {
                MessageBox.Show("X has won!", "Congratulations");
                Button_Click(null, null);
                Xwins++;
            }
            else if ((string)btnButton1.Content == "O" && (string)btnButton2.Content == "O" && (string)btnButton3.Content == "O" || (string)btnButton4.Content == "O" && (string)btnButton5.Content == "O" && (string)btnButton6.Content == "O" || (string)btnButton7.Content == "O" && (string)btnButton8.Content == "O" && (string)btnButton9.Content == "O" || (string)btnButton1.Content == "O" && (string)btnButton4.Content == "O" && (string)btnButton7.Content == "O" || (string)btnButton2.Content == "O" && (string)btnButton5.Content == "O" && (string)btnButton8.Content == "O" || (string)btnButton3.Content == "O" && (string)btnButton6.Content == "O" && (string)btnButton9.Content == "O" || (string)btnButton1.Content == "O" && (string)btnButton5.Content == "O" && (string)btnButton9.Content == "O" || (string)btnButton3.Content == "O" && (string)btnButton5.Content == "O" && (string)btnButton7.Content == "O")
            {
                MessageBox.Show("O has won!", "Congratulations");
                Button_Click(null, null);
                Owins++;
            }
            else if ((string)btnButton1.Content != "" && (string)btnButton2.Content != "" && (string)btnButton3.Content != "" && (string)btnButton4.Content != "" && (string)btnButton5.Content != "" && (string)btnButton6.Content != "" && (string)btnButton7.Content != "" && (string)btnButton8.Content != "" && (string)btnButton9.Content != "")
            {
                MessageBox.Show("It's a tie!!!", "");
                Button_Click(null, null);
            }
        }
    }
}
