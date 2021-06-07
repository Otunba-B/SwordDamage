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

namespace SwordDamage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SwordDamage swordDamage = new SwordDamage();
        public MainWindow()
        {
            InitializeComponent();
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(false);
            RollDice();
        }

        private void flaming_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void flaming_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void magic_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void magic_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
