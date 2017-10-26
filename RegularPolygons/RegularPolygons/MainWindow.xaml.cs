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

namespace RegularPolygons
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ObliczButton_Click(object sender, RoutedEventArgs e)
        {
            if (DlugoscBoku.Text.Length == 0)
            {
                MessageBox.Show("Podaj długość boku!");
                return;
            }

            string Text = Figura.Text;

            if (String.IsNullOrEmpty(Text))
            {
                MessageBox.Show("Wybierz rodzaj figury!");
                return;
            }

            try
            {
                double a = double.Parse(DlugoscBoku.Text);

                if (a <= 0)
                {
                    MessageBox.Show("Podaj wartośc większą niż 0!");
                    return;
                }

                switch (Text)
                {
                    case "Trójkąt":
                        ObliczTrojkat(a);
                        break;
                    case "Kwadrat":
                        ObliczKwadrat(a);
                        break;
                    case "Pięciokąt":
                        ObliczPieciokat(a);
                        break;
                    case "Sześciokąt":
                        ObliczSzesciokat(a);
                        break;
                    case "Ośmiokąt":
                        ObliczOsmiokat(a);
                        break;
                    case "Dziesięciokąt":
                        ObliczDziesieciokat(a);
                        break;
                    case "Dwunastokąt":
                        ObliczDwunastokat(a);
                        break;
                    default:
                        break;
                }
            }

            catch (FormatException err)
            {
                MessageBox.Show("Długość boku musi być liczbą!");
            }

        }

        public void WyczyscButton_Click(object sender, RoutedEventArgs e)
        {
            Figura.Text = null;
            DlugoscBoku.Text = null;
            Pole.Text = null;
            OkragOpisany.Text = null;
            OkragWpisany.Text = null;
        }
        public void ObliczTrojkat(double a)
        {
            Pole.Text = Math.Round((Math.Pow(a, 2) * Math.Pow(3, 0.5)) / 4, 2).ToString();
            OkragOpisany.Text = Math.Round((a * Math.Pow(3, 0.5)) / 3, 2).ToString();
            OkragWpisany.Text = Math.Round((a * Math.Pow(3, 0.5)) / 6, 2).ToString();
        }
        public void ObliczKwadrat(double a)
        {
            Pole.Text = Math.Round(Math.Pow(a, 2), 2).ToString();
            OkragOpisany.Text = Math.Round((a * Math.Pow(2, 0.5)) / 2, 2).ToString();
            OkragWpisany.Text = Math.Round(a / 2, 2).ToString();
        }
        public void ObliczPieciokat(double a)
        {
            Pole.Text = Math.Round((Math.Pow(a, 2) * Math.Pow(5 * (5 + 2 * Math.Pow(5, 0.5)), 0.5)) / 4, 2).ToString();
            OkragOpisany.Text = Math.Round((2 * a) / Math.Pow(2 * (5 - Math.Pow(5, 0.5)), 0.5), 2).ToString();
            OkragWpisany.Text = Math.Round(a / (2 * Math.Pow(5 - 2 * Math.Pow(5, 0.5), 0.5)), 2).ToString();
        }
        public void ObliczSzesciokat(double a)
        {
            Pole.Text = Math.Round((3 * Math.Pow(a, 2) * Math.Pow(3, 0.5)) / 2, 2).ToString();
            OkragOpisany.Text = Math.Round(a, 2).ToString();
            OkragWpisany.Text = Math.Round((a * Math.Pow(3, 0.5)) / 2, 2).ToString();
        }
        public void ObliczOsmiokat(double a)
        {
            Pole.Text = Math.Round(2 * Math.Pow(a, 2) * (1 + Math.Pow(2, 0.5)), 2).ToString();
            OkragOpisany.Text = Math.Round(a * Math.Pow((2 + Math.Pow(2, 0.5)) / 2, 0.5), 2).ToString();
            OkragWpisany.Text = Math.Round((a * (1 + Math.Pow(2, 0.5))) / 2, 2).ToString();
        }
        public void ObliczDziesieciokat(double a)
        {
            Pole.Text = Math.Round(5 * (Math.Pow(a, 2) * Math.Pow(5 + 2 * Math.Pow(5, 0.5), 0.5)) / 2, 2).ToString();
            OkragOpisany.Text = Math.Round((a * (1 + Math.Pow(5, 0.5))) / 2, 2).ToString();
            OkragWpisany.Text = Math.Round((a * Math.Pow(5 + 2 * Math.Pow(5, 0.5), 0.5)) / 2, 2).ToString();
        }
        public void ObliczDwunastokat(double a)
        {
            Pole.Text = Math.Round(3 * Math.Pow(a, 2) * (2 + Math.Pow(3, 0.5)), 2).ToString();
            OkragOpisany.Text = Math.Round((a * Math.Pow(2, 0.5) * (Math.Pow(3, 0.5) + 1)) / 2, 2).ToString();
            OkragWpisany.Text = Math.Round((a * (2 + Math.Pow(3, 0.5))) / 2, 2).ToString();
        }
    }
}
