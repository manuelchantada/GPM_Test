using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public class InputValidator
    {
        public static bool[] textBoxsStatus = { false, false, false, false, false, false, false, false };

        private static bool ValidateInt(string text)
        {
            return int.TryParse(text, out int _);           
        }

        public static bool ValidateCoordinate(TextBox textBox)
        {
            string text = textBox.Text;
            bool isValidInt = ValidateInt(text);
            if (!isValidInt)
            {
                Messages.ShowWrongCoordinateMessage(text);                
            }
            textBox.Background = isValidInt ? Brushes.Green : Brushes.Red;
            textBoxsStatus[Int32.Parse(textBox.Uid)] = isValidInt;
            return isValidInt;

        }
        public static bool ValidateHeight(TextBox textBox)
        {
            string text = textBox.Text;
            bool isValidInt = ValidateInt(text);
            if (!isValidInt)
            {
                Messages.ShowWrongHeightMessage(text);
            }
            textBox.Background = isValidInt ? Brushes.Green : Brushes.Red;
            textBoxsStatus[Int32.Parse(textBox.Uid)] = isValidInt;
            return isValidInt;
        }

        public static bool AllInputIsValid()
        {
            return !textBoxsStatus.Contains(false);
        }
    }
}
