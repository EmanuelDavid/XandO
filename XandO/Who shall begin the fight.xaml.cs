using System.Windows;

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
