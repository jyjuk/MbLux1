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
using System.Windows.Shapes;

namespace MbLux
{
    /// <summary>
    /// Interaction logic for Configurator.xaml
    /// </summary>
    public partial class Configurator : Window
    {
        public Configurator()
        {
            InitializeComponent();
            LoadPrice();
        }
        public void LoadPrice()
        {
            txtBox_Pluta1.Text = (Properties.Settings.Default.cinaPluta1Cina).ToString();
            txtBox_Pluta2.Text = (Properties.Settings.Default.cinaPluta2Cina).ToString();
            txtBox_Stilnica28.Text = (Properties.Settings.Default.stilnica28Cina).ToString();
            txtBox_Stilnica38.Text = (Properties.Settings.Default.stilnica38Cina).ToString();
            txtBox_Fasad.Text = (Properties.Settings.Default.fasadCina).ToString();
            txtBox_Pcv.Text = (Properties.Settings.Default.pcvCina).ToString();
            txtBox_Alu.Text = (Properties.Settings.Default.aluCina).ToString();
            txtBox_PolnijVysuv.Text = (Properties.Settings.Default.povnyjVusyvNapravCina).ToString();
            txtBox_ObichnijNaprav.Text = (Properties.Settings.Default.zvychajniNapravCina).ToString();
            txtBox_Cargo.Text = (Properties.Settings.Default.cargoCina).ToString();
            txtBox_Ruchki.Text = (Properties.Settings.Default.rychkiCina).ToString();
            txtBox_NogaKuhona.Text = (Properties.Settings.Default.nogiKuhonniCina).ToString();
            txtBox_Shurup.Text = (Properties.Settings.Default.shyryp3_5Cina).ToString();
            txtBox_Konfirmat.Text = (Properties.Settings.Default.konfirmatCina).ToString();
            txtBox_Zavis.Text = (Properties.Settings.Default.zavisCina).ToString();
            txtBox_Karniz.Text = (Properties.Settings.Default.karizCina).ToString();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.cinaPluta1Cina=Double.Parse(txtBox_Pluta1.Text.Replace('.',','));
            Properties.Settings.Default.cinaPluta2Cina = Double.Parse(txtBox_Pluta2.Text.Replace('.', ','));
            Properties.Settings.Default.stilnica28Cina = Double.Parse(txtBox_Stilnica28.Text.Replace('.', ','));
            Properties.Settings.Default.stilnica38Cina = Double.Parse(txtBox_Stilnica38.Text.Replace('.', ','));
            Properties.Settings.Default.fasadCina = Double.Parse(txtBox_Fasad.Text.Replace('.', ','));
            Properties.Settings.Default.pcvCina = Double.Parse(txtBox_Pcv.Text.Replace('.', ','));
            Properties.Settings.Default.aluCina = Double.Parse(txtBox_Alu.Text.Replace('.', ','));
            Properties.Settings.Default.povnyjVusyvNapravCina = Double.Parse(txtBox_PolnijVysuv.Text.Replace('.', ','));
            Properties.Settings.Default.zvychajniNapravCina = Double.Parse(txtBox_ObichnijNaprav.Text.Replace('.', ','));
            Properties.Settings.Default.cargoCina = Double.Parse(txtBox_Cargo.Text.Replace('.', ','));
            Properties.Settings.Default.rychkiCina = Double.Parse(txtBox_Ruchki.Text.Replace('.', ','));
            Properties.Settings.Default.nogiKuhonniCina = Double.Parse(txtBox_NogaKuhona.Text.Replace('.', ','));
            Properties.Settings.Default.shyryp3_5Cina = Double.Parse(txtBox_Shurup.Text.Replace('.', ','));
            Properties.Settings.Default.konfirmatCina = Double.Parse(txtBox_Konfirmat.Text.Replace('.', ','));
            Properties.Settings.Default.zavisCina = Double.Parse(txtBox_Zavis.Text.Replace('.', ','));
            Properties.Settings.Default.karizCina = Double.Parse(txtBox_Karniz.Text.Replace('.', ','));
            Properties.Settings.Default.Save();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();

        }
    }
}
