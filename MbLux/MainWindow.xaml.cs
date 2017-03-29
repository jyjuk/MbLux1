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

namespace MbLux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetVerhNuzVisibleToFalse();
        }

        Verh vr = new Verh();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Configurator cf = new Configurator();
            cf.Show();
            this.Close();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double price = vr.V15(kilkistV15);

            MessageBox.Show((price).ToString());
        }
        private void btnFactura_Click(object sender, RoutedEventArgs e)
        {

        }
        private int ChekInt(string s)
        {
            int i;
            try
            {
                i = Int32.Parse(s);
                return i;
            }
            catch (FormatException)
            {
                i = -3;
                return i;
            }

        }
        private void SetVerhNuzVisibleToFalse()
        {
            txtV15.IsEnabled = false;
            txtV30.IsEnabled = false;
            txtV40.IsEnabled = false;
            txtV45.IsEnabled = false;
            txtV60.IsEnabled = false;
            txtVkut.IsEnabled = false;
            txtVVytjazka.IsEnabled = false;
            txtN15.IsEnabled = false;
            txtN30.IsEnabled = false;
            txtN40.IsEnabled = false;
            txtN45.IsEnabled = false;
            txtN60.IsEnabled = false;
            txtNkut.IsEnabled = false;
            txtNPlyta.IsEnabled = false;
            txtNCargo.IsEnabled = false;
            txtNSushka.IsEnabled = false;

        }


        int kilkistVerhnih = 0;
        int kilkistV15 = 0;
        int kilkistV30 = 0;
        int kilkistV40 = 0;
        int kilkistV45 = 0;
        int kilkistV60 = 0;
        int kilkistVytjazka = 0;
        int kilkistNKut = 0;
        int kilkistN15 = 0;
        int kilkistN30 = 0;
        int kilkistN40 = 0;
        int kilkistN45 = 0;
        int kilkistN60 = 0;
        int kilkistNPlyta = 0;
        int kilkistCargo = 0;
        int kilkistNSushka = 0;


        private void chkVKut_Checked(object sender, RoutedEventArgs e)
        {
            txtVkut.IsEnabled = true;

        }

        private void chkV15_Checked(object sender, RoutedEventArgs e)
        {
            txtV15.IsEnabled = true;
        }

        private void chkV30_Checked(object sender, RoutedEventArgs e)
        {
            txtV30.IsEnabled = true;
        }

        private void chkV40_Checked(object sender, RoutedEventArgs e)
        {
            txtV40.IsEnabled = true;
        }

        private void chkV45_Checked(object sender, RoutedEventArgs e)
        {
            txtV45.IsEnabled = true;
        }

        private void chkV60_Checked(object sender, RoutedEventArgs e)
        {
            txtV60.IsEnabled = true;
        }

        private void chkVVytjazka_Checked(object sender, RoutedEventArgs e)
        {
            txtVVytjazka.IsEnabled = true;
        }

        private void chkVKut_Unchecked(object sender, RoutedEventArgs e)
        {
            txtVkut.Text = "0";
            txtVkut.IsEnabled = false;


        }

        private void chkV15_Unchecked(object sender, RoutedEventArgs e)
        {
            txtV15.IsEnabled = false;
            txtV15.Text = "0";
        }

        private void chkV30_Unchecked(object sender, RoutedEventArgs e)
        {
            txtV30.IsEnabled = false;
            txtV30.Text = "0";
        }

        private void chkV40_Unchecked(object sender, RoutedEventArgs e)
        {
            txtV40.IsEnabled = false;
            txtV40.Text = "0";

        }

        private void chkV45_Unchecked(object sender, RoutedEventArgs e)
        {
            txtV45.IsEnabled = false;
            txtV45.Text = "0";

        }

        private void chkV60_Unchecked(object sender, RoutedEventArgs e)
        {
            txtV60.IsEnabled = false;
            txtV60.Text = "0";

        }

        private void chkVVytjazka_Unchecked(object sender, RoutedEventArgs e)
        {
            txtVVytjazka.IsEnabled = false;
            txtVVytjazka.Text = "0";
        }



        private void txtVkut_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtVkut.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistVerhnih = Int32.Parse(s);

        }

        private void txtV15_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtV15.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                kilkistV15 = Int32.Parse(s);

            }
        }

        private void txtV30_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtV30.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistV30 = Int32.Parse(s);
        }

        private void txtV40_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtV40.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistV40 = Int32.Parse(s);
        }

        private void txtV45_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtV45.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistV45 = Int32.Parse(s);
        }

        private void txtV60_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtV60.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistV60 = Int32.Parse(s);
        }

        private void txtVVytjazka_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtVVytjazka.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistVytjazka = Int32.Parse(s);

        }

        private void chkNKut_Checked(object sender, RoutedEventArgs e)
        {
            txtNkut.IsEnabled = true;
        }

        private void chkN15_Checked(object sender, RoutedEventArgs e)
        {
            txtN15.IsEnabled = true;
        }

        private void chkN30_Checked(object sender, RoutedEventArgs e)
        {
            txtN30.IsEnabled = true;
        }

        private void chkN40_Checked(object sender, RoutedEventArgs e)
        {
            txtN40.IsEnabled = true;
        }

        private void chkN45_Checked(object sender, RoutedEventArgs e)
        {
            txtN45.IsEnabled = true;
        }

        private void chkN60_Checked(object sender, RoutedEventArgs e)
        {
            txtN60.IsEnabled = true;
        }

        private void chkNPlyta_Checked(object sender, RoutedEventArgs e)
        {
            txtNPlyta.IsEnabled = true;
        }

        private void txtNkut_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtNkut.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistNKut = Int32.Parse(s);
        }

        private void txtN15_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtN15.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistN15 = Int32.Parse(s);
        }

        private void txtN30_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtN30.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistN30 = Int32.Parse(s);

        }

        private void txtN40_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtN40.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistN40 = Int32.Parse(s);
        }

        private void txtN45_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtN45.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistN45 = Int32.Parse(s);
        }

        private void txtN60_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtN60.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistN60 = Int32.Parse(s);

        }

        private void txtNPlyta_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtNPlyta.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistNPlyta = Int32.Parse(s);
        }

        private void chkNKut_Unchecked(object sender, RoutedEventArgs e)
        {
            txtNkut.IsEnabled = false;
            txtNkut.Text = "0";
        }

        private void chkN15_Unchecked(object sender, RoutedEventArgs e)
        {
            txtN15.IsEnabled = false;
            txtNkut.Text = "0";
        }

        private void chkN30_Unchecked(object sender, RoutedEventArgs e)
        {
            txtN30.IsEnabled = false;
            txtNkut.Text = "0";
        }

        private void chkN40_Unchecked(object sender, RoutedEventArgs e)
        {
            txtN40.IsEnabled = false;
            txtNkut.Text = "0";
        }

        private void chkN45_Unchecked(object sender, RoutedEventArgs e)
        {
            txtN45.IsEnabled = false;
            txtNkut.Text = "0";
        }

        private void chkN60_Unchecked(object sender, RoutedEventArgs e)
        {
            txtN60.IsEnabled = false;
            txtNkut.Text = "0";
        }

        private void chkNPlyta_Unchecked(object sender, RoutedEventArgs e)
        {
            txtNPlyta.IsEnabled = false;
            txtNkut.Text = "0";
        }

        private void chkNCargo_Checked(object sender, RoutedEventArgs e)
        {
            txtNCargo.IsEnabled = true;
        }

        private void txtNCargo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtNCargo.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistCargo = Int32.Parse(s);
        }

        private void chkNCargo_Unchecked(object sender, RoutedEventArgs e)
        {
            txtNCargo.IsEnabled = false;
            txtNCargo.Text = "0";
        }

        private void txtNSushka_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = txtNSushka.Text;
            if (ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                kilkistNSushka = Int32.Parse(s);
        }

        private void chkNSushka_Checked(object sender, RoutedEventArgs e)
        {
            txtNSushka.IsEnabled = true;
        }

        private void chkNSushka_Unchecked(object sender, RoutedEventArgs e)
        {
            txtNSushka.IsEnabled = false;
            txtNSushka.Text = "0";

        }
    }
}


