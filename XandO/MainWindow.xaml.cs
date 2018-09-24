using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XandO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] _matrix;

        private Helper.Player _currentPlayerTurn = Helper.Player.Cross;

        public MainWindow()
        {
            InitializeComponent();
            InitialiseMatrix();

            Who_shall_begin_the_fight questionForm = new Who_shall_begin_the_fight();
            questionForm.ShowDialog();

            _currentPlayerTurn = questionForm.PlayerToStart;
        }

        private void InitialiseMatrix()
        {
            _matrix = new Button[,]
            {
                {Button0_0, Button0_1, Button0_2},
                {Button1_0, Button1_1, Button1_2},
                {Button2_0, Button2_1, Button2_2}
            };

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    _matrix[row, col].Content = null;
                    _matrix[row, col].Background = Brushes.White;
                }
            }
        }

        private void Button0_0_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button0_1_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button0_2_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button1_0_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button1_1_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button2_0_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button2_1_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button2_2_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void Button1_2_Click(object sender, RoutedEventArgs e)
        {
            SetButtonContent(sender);
            ShowWinner(GetWinner());
        }

        private void SetButtonContent(object sender)
        {
            var button = (sender as Button);

            if (button.Content != null)
            {
                return;
            }

            if (_currentPlayerTurn == Helper.Player.Cross)
            {
                button.Content = Helper.Cross;
                _currentPlayerTurn = Helper.Player.Nought;
            }
            else
            {
                button.Content = Helper.Nought;
                _currentPlayerTurn = Helper.Player.Cross;
            }
        }

        private string GetWinner()
        {
            if((_matrix[0, 0].Content == _matrix[0, 1].Content) && (_matrix[0, 1].Content ==_matrix[0, 2].Content))
            {
                var result = _matrix[0, 0].Content?.ToString();
                if(result != null)
                {
                    _matrix[0, 0].Background = _matrix[0, 1].Background = _matrix[0, 2].Background = Brushes.Green;

                    return result;
                }
            }

            if ((_matrix[1, 0].Content == _matrix[1, 1].Content) && (_matrix[1, 1].Content == _matrix[1, 2].Content))
            {
                var result = _matrix[1, 0].Content?.ToString();
                if (result != null)
                {
                    _matrix[1, 0].Background = _matrix[1, 1].Background = _matrix[1, 2].Background = Brushes.Green;

                    return result;
                }
            }

            if ((_matrix[2, 0].Content == _matrix[2, 1].Content) && (_matrix[2, 1].Content == _matrix[2, 2].Content))
            {
                var result = _matrix[2, 0].Content?.ToString();
                if (result != null)
                {
                    _matrix[2, 0].Background = _matrix[2, 1].Background = _matrix[2, 2].Background = Brushes.Green;

                    return result;
                }
            }

            if ((_matrix[0, 0].Content == _matrix[1, 0].Content) && (_matrix[1, 0].Content == _matrix[2, 0].Content))
            {
                var result = _matrix[0, 0].Content?.ToString();
                if (result != null)
                {
                    _matrix[0, 0].Background = _matrix[1, 0].Background = _matrix[2, 0].Background = Brushes.Green;

                    return result;
                }
            }

            if ((_matrix[0, 1].Content == _matrix[1, 1].Content) && (_matrix[1, 1].Content == _matrix[2, 1].Content))
            {
                var result = _matrix[0, 1].Content?.ToString();
                if (result != null)
                {
                    _matrix[0, 1].Background = _matrix[1, 1].Background = _matrix[2, 1].Background = Brushes.Green;

                    return result;
                }
            }

            if ((_matrix[0, 2].Content == _matrix[1, 2].Content) && (_matrix[1, 2].Content == _matrix[2, 2].Content))
            {
                var result = _matrix[0, 2].Content?.ToString();
                if (result != null)
                {
                    _matrix[0, 2].Background = _matrix[1, 2].Background = _matrix[2, 2].Background = Brushes.Green;

                    return result;
                }
            }

            if ((_matrix[0, 0].Content == _matrix[1, 1].Content) && (_matrix[1, 1].Content == _matrix[2, 2].Content))
            {
                var result = _matrix[0, 0].Content?.ToString();
                if (result != null)
                {
                    _matrix[0, 0].Background = _matrix[1, 1].Background = _matrix[2, 2].Background = Brushes.Green;

                    return result;
                }
            }

            if ((_matrix[0, 2].Content == _matrix[1, 1].Content) && (_matrix[1, 1].Content == _matrix[2, 0].Content))
            {
                var result = _matrix[0, 2].Content?.ToString();
                if (result != null)
                {
                    _matrix[0, 2].Background = _matrix[1, 1].Background = _matrix[2, 0].Background = Brushes.Green;

                    return result;
                }
            }

            return null;
        }

        private void ShowWinner(string winner)
        {
            if (winner != null)
            {
                MessageBox.Show($"The winner is {winner}");

                if(MessageBox.Show("Do you whant to play again?", "Question",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    InitialiseMatrix();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
