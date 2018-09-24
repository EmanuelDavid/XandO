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

namespace XandO
{
    /// <summary>
    /// Interaction logic for Who_shall_begin_the_fight.xaml
    /// </summary>
    public partial class Who_shall_begin_the_fight : Window
    {
        public Who_shall_begin_the_fight()
        {
            InitializeComponent();
        }

        public Helper.Player PlayerToStart { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlayerToStart = Helper.Player.Nought;
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PlayerToStart = Helper.Player.Cross;
            Close();
        }
    }
}
