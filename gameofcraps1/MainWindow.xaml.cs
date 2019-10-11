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

namespace gameofcraps1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // this x is used to create random values.
        Random x = new Random();
       
        // below fields are used to store randome values of dice
        int rx = 0, ry = 0, rt =0;

        // it is used to store point value
        int point = 0;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // it will create two random value of the dice
            rx = x.Next(1, 7);
            ry = x.Next(1, 7);
            textBox1.Text = "Outcome is " + rx.ToString() + "," + ry.ToString();
            rt = rx + ry;

            if (point == rt)
            {
                textBox2.Text = "You Win !!!";
                button1.IsEnabled = false;
                button.IsEnabled = true;
            }
            else if (rt == 7)
            {
                textBox2.Text = "You Lose !!!";
                button1.IsEnabled = false;
                button.IsEnabled = true;
            }


        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // this will set initail values to blank and generate random numbers
            textBox2.Text = "";
            textBox.Text = "";
            rx = x.Next(1, 7);
            ry = x.Next(1, 7);

            textBox1.Text = "Outcome is " + rx.ToString() + "," + ry.ToString();
            rt = rx + ry;

            // based on case it will take decision
            switch(rt)
            {
                case 7:
                case 11:

                    button1.IsEnabled = false;
                    textBox2.Text = "You Win !!!";
                    break;


                case 2:
                case 3:
                case 12:

                    button1.IsEnabled = false;
                    textBox2.Text = "You Lose !!!";
                    break;


                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                case 10:
                    point = rt;
                    textBox.Text = "Point is " + point.ToString();
                    MessageBox.Show("Roll again");
                    button.IsEnabled = false;
                    button1.IsEnabled = true;
                    break;

                default:


                    break;


            }            


        }
    }
}
