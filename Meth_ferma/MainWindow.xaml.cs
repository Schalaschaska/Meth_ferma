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

namespace Meth_ferma
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(textBox.Text);
            double S = 0;
            double y;
            double k = 1;
            double sqr_S = Math.Sqrt(S);
            bool flag=true;
            double pr_rez = 0;
            bool prost = true;
            double mn = 0;
            double mn2 = 0;
            

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                MessageBox.Show("Число простое");
            }
            else
            {
               MessageBox.Show("Число не простое");
            }
         
            Pr Ob = new Pr();
            while(Ob.flag)
            {
                mn = Ob.Z(n);
                mn2 = Ob.Z2(n);
                
            }
            {

            }
            
            label1.Content = "Разложение числа " + n + " было достигнуто за " + (Ob.k-1)+ " итераций\nПервый множитель " + Convert.ToString(Ob.Z(n)) + "\nВторой множитель " + Convert.ToString(Ob.Z2(n));
        }


        }
    }


