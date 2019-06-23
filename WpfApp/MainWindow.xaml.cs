using Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1;

namespace WpfApp
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

        private void TextBoxCoord_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                InputValidator.ValidateCoordinate(textBox);

                buttonCalculate.IsEnabled = InputValidator.AllInputIsValid();
            }            
        }

        private void TextBoxHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                InputValidator.ValidateHeight(textBox);

                buttonCalculate.IsEnabled = InputValidator.AllInputIsValid();
            }
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            Cube A = new Cube(new Coordinate(int.Parse(X1.Text), int.Parse(Y1.Text), int.Parse(Z1.Text))
                , int.Parse(H1.Text) );
            Cube B = new Cube(new Coordinate(int.Parse(X2.Text), int.Parse(Y2.Text), int.Parse(Z2.Text))
                , int.Parse(H2.Text));
            ICollisionCalc calc = CollisionCalcFactory.CreateCollisionCalc(A, B);
            float colidedVolume = calc.CollidedVolume();
            Messages.ShowResultVolumeMessage(colidedVolume);
        }


    }
}
