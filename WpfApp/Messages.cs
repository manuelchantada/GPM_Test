using System;
using System.Windows;

namespace WpfApp1
{
    public class Messages
    {
        static bool WrongCoordMessageShowed = false;
        static bool WrongHeightMessageShowed = false;
        public static void ShowResultVolumeMessage(float colidedVolume)
        {
            string text = colidedVolume != 0 ? $"Volumen de Colisión: {colidedVolume}" : "No existe colisión";
            MessageBox.Show(text);
        }

        public static void ShowWrongCoordinateMessage(string text)
        {
            if (!WrongCoordMessageShowed)
            {
                MessageBox.Show($"Todas las Coordenadas deben ser enteros. Error: '{text}'");
                WrongCoordMessageShowed = true;
            }
        }
        public static void ShowWrongHeightMessage(string text)
        {
            if (!WrongHeightMessageShowed)
            {
                MessageBox.Show($"Todas las Alturas deben ser enteros. Error: '{text}'");
                WrongHeightMessageShowed = true;
            }
        }
    }
}
