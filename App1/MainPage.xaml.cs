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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void output_Click(object sender, RoutedEventArgs e)
        {
            string result = "";

            int x = 3;

            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }
                x = x - 1;
                result = result + "-";
                if (x == 2)
                {
                    result = result + "b c";
                }
                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }
            }

            output.Text = result;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            string poem = "";

            while (x < 4)
            {
                poem = poem + "a";
            if (x < 1)
            {
                poem = poem + " ";
            }
            poem = poem + "n";
            if (x > 1)
            {
                poem = poem + " oyster";
                x = x + 2;
            }
            if (x == 1)
            {
                poem = poem + "noys ";
            }
            if (x < 1)
            {
                poem = poem + "oise ";
            }
            x = x + 1;
            }
        }
        output.Text = poem;
    }
}
