using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static int i = 0;
        private DependencyProperty dp;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "1";
            else
                textblock3.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "2";
            else
                textblock3.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "3";
            else
                textblock3.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "4";
            else
                textblock3.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "5";
            else
                textblock3.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "6";
            else
                textblock3.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "7";
            else
                textblock3.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "8";
            else
                textblock3.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "9";
            else
                textblock3.Text += "9";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            i = 1;
            textblock2.Text = "+";
        }
       
        private void sub_Click(object sender, RoutedEventArgs e)
        {
            i = 1;
            textblock2.Text = "-";
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            i = 1;
            textblock2.Text = "*";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            i = 1;
            textblock2.Text = "/";
        }

        private void eq_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            int x, y;
            int res=0;
            string z;
            x = Convert.ToInt32(textblock1.Text);
            x = int.Parse(textblock1.Text);
            y = Convert.ToInt32(textblock3.Text);
            y = int.Parse(textblock3.Text);
            z = Convert.ToString(textblock2.Text);
            switch (z)
            {
                case "+": res = x + y;
                    break;
                case "-": res = x - y;
                    break;
                case "*": res = x * y;
                    break;
                case "/": res = x / y;
                    break;
                /*default: textblock1.Text = null;
                    textblock2.Text = null;
                    textblock3.Text = null;*/
            }
            textblock4.Text = res.ToString();
            textblock1.Text = textblock4.Text;
            textblock2.Text = "";
            textblock3.Text = "";
        }

        private void clr_Click(object sender, RoutedEventArgs e)
        {
            textblock1.Text = "";
            textblock2.Text = "";
            textblock3.Text = "";
            textblock4.Text = "";
            i = 0;
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
                textblock1.Text += "0";
            else
                textblock3.Text += "0";
        }

        private void textblock1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
