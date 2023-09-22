using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Cal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int ParaNum = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ParaNum = 1;
            Display.Text = string.Empty;
        }
        private static double JsEval(string expression)
        {
            double result;
            try
            {
                System.Data.DataTable table = new();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                System.Data.DataRow row = table.NewRow();
                table.Rows.Add(row);
                result = double.Parse((string)row["expression"]);
            } catch
            {
                MessageBox.Show("Invaild operation");
                result = 0;
            }
            if (result == double.PositiveInfinity || result == double.NegativeInfinity) result = 0;
            return result;
            

        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            ParaNum = 1;
            Display.Text = Convert.ToString(JsEval(Display.Text));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement frameworkElement = e.Source as FrameworkElement;
            switch(frameworkElement.Name)
            {
                case "One":
                    Display.Text += "1";
                    break;
                case "Two":
                    Display.Text += "2";
                    break;
                case "Three":
                    Display.Text += "3";
                    break;

                case "Four":
                    Display.Text += "4";
                    break;
                case "Five":
                    Display.Text += "5";
                    break;
                case "Six":
                    Display.Text += "6";
                    break;

                case "Seven":
                    Display.Text += "7";
                    break;
                case "Eight":
                    Display.Text += "8";
                    break;
                case "Nine":
                    Display.Text += "9";
                    break;
                case "Zero":
                    Display.Text += "0";
                    break;

                case "Dot":
                    Display.Text += ".";
                    break;

                case "Add":
                    Display.Text += "+";
                    break;
                case "Minus":
                    Display.Text += "-";
                    break;

                case "Multi":
                    Display.Text += "*";
                    break;
                case "Div":
                    Display.Text += "/";
                    break;

                case "Mod":
                    Display.Text += "%";
                    break;
                case "Para":
                    if (ParaNum == 2)
                    {
                        Display.Text += ")";
                        ParaNum = 1;
                    } else
                    {
                        Display.Text += "(";
                        ParaNum = 2;
                    }
                    break;

            }
        }
    }
}
