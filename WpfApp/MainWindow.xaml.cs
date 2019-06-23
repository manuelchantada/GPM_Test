using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool[] textBoxsStatus = { false, false, false, false, false, false, false, false };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;
            string text = textBox.Text;

            if (text != "" && !int.TryParse(text, out int value))
            {
                textBox.Background = Brushes.Red;
                textBoxsStatus[ Int32.Parse(textBox.Uid) ] = false;
                //MessageBox.Show("Todos los Valores deben ser enteros");
            }
            else
            {
                textBoxsStatus[Int32.Parse(textBox.Uid)] = true;
                textBox.Background = Brushes.Green;
            }
            if (!textBoxsStatus.Contains(false))
            {
                buttonCalculate.IsEnabled = true;
            }
            else
            {
                buttonCalculate.IsEnabled = false;
            }
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
