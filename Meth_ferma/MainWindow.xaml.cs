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
using System.Text.RegularExpressions;


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
       public double mn = 0;
       public double mn2 = 0;
       public double mn_2 = 0;
       public double mn2_2 = 0;
        public double mn_2_s = 0;
        public double mn2_2_s = 0;
        public bool p_f_1 = false;
       public bool p_f_2 = false;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "";
            p_f_1 = false;
            p_f_2 = false;
            Regex X = new Regex(@"^\d+$");
            if (X.IsMatch(textBox.Text))
            {
                double n = Convert.ToDouble(textBox.Text);
                if (n % 2 == 0)
                {
                    MessageBox.Show("Факторизация невыполнима");
                }
                else
                {
                    double S = 0;
                    double sqr_S = Math.Sqrt(S);
                    bool prost = true;

                    Pr Ob = new Pr();
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

                        mn = Ob.Z(n);
                        mn2 = Ob.Z2(n);
                        prost = true;
                        for (int i = 2; i <= mn / 2; i++)
                        {
                            if (mn % i == 0)
                            {
                                prost = false;
                                break;
                            }
                        }
                        if (prost)
                        {
                            // MessageBox.Show("Первый множитель простой");
                        }
                        else
                        {
                            // MessageBox.Show("Первый множитель составной");
                            Pr ob_1 = new Pr();
                            mn_2 = ob_1.Z(mn);
                            mn2_2 = ob_1.Z2(mn);
                            p_f_1 = true;
                        }
                        for (int i = 2; i <= mn2 / 2; i++)
                        {
                            if (mn2 % i == 0)
                            {
                                prost = false;
                                break;
                            }
                        }
                        if (prost)
                        {
                            //MessageBox.Show("Второй множитель простой");
                        }
                        else
                        {
                            //MessageBox.Show("Второй множитель составной");
                            Pr ob_2 = new Pr();
                            mn_2_s = ob_2.Z(mn2);
                            mn2_2_s = ob_2.Z2(mn2);
                            p_f_2 = true;


                        }

                        label1.Content = "Разложение числа " + n + " произошло за " + Ob.k + " итераций\nПервый множитель " + mn + "\nВторой множитель " + mn2;
                        if (p_f_1 == true)
                        {
                            label1.Content = "Разложение числа " + n + " произошло за " + Ob.k + " итераций\nПервый множитель " + mn_2 + " и " + mn2_2 + "\nВторой множитель " + mn2;
                            
                        }
                        if (p_f_2 == true)
                        {
                            label1.Content = "Разложение числа " + n + " произошло за " +Ob.k + " итераций\nПервый множитель " + mn + "\nВторой множитель " + mn_2_s + " и " + mn2_2_s;
                            
                        }
                        if (p_f_1 == true && p_f_2 == true)
                        {
                            label1.Content = "Разложение числа " + n + " произошло за " +Ob.k  + " итераций\nПервый множитель " + mn_2 + " и " + mn2_2 + "\nВторой множитель " + mn_2_s + " и " + mn2_2_s;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
         
    }
    }


