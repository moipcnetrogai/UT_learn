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

namespace NomerWPF
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

       

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            string NomAvto;
            NomAvto = TBoxEnter.Text;

            Proverka pv = new Proverka();

            string res = pv.proverkaCAR(NomAvto);

            MessageBox.Show(res);
        }

        private void BtnCheckEmail_Click(object sender, RoutedEventArgs e)
        {
            string email = TBoxEmail.Text;
            Proverka pv = new Proverka();
            string res = pv.proverkaEMAIL(email);
            MessageBox.Show(res);
        }
    }
}
