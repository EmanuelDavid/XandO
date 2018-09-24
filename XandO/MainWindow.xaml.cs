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

namespace XandO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool playerXTurn;

        private bool gameOver;

        private Helper.MarckType[,] _matrix;

        private Helper.Player _firstPlayer = Helper.Player.Cross;

        public MainWindow()
        {
            InitializeComponent();
            InitialiseMatrix();

            Who_shall_begin_the_fight questionForm = new Who_shall_begin_the_fight();
            questionForm.ShowDialog();

            _firstPlayer = questionForm.PlayerToStart;

            while (!gameOver)
            {

                gameOver = true;
            }
            ShowCurrentStatus();
        }

        private void InitialiseMatrix()
        {
            _matrix = new Helper.MarckType[3,3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    _matrix[row,col] = Helper.MarckType.Free;
                }
            }
        }

        public void ShowCurrentStatus()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    switch(_matrix[row, col])
                    {
                        case Helper.MarckType.Free:
                            Button0_0.Content = "";
                            break;
                        case Helper.MarckType.Cross:
                            Button0_0.Content = "X";
                            break;
                        case Helper.MarckType.Nought:
                            Button0_0.Content = "O";
                            break;
                    }
                }
            }
        }

    }
}
