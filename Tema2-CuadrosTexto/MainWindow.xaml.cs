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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombre_Textbox.Tag = nombre_Textblock;
            apellido_Textbox.Tag = apellido_Textblock;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1)
            {
                TextBlock texto = (TextBlock)(sender as TextBox).Tag;
                if (texto.Visibility == Visibility.Hidden) texto.Visibility = Visibility.Visible;
                else texto.Visibility = Visibility.Hidden;
            }
        }
        private void TextBox_KeyDown2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (int.TryParse(edad_Textbox.Text, out _))
                {
                    edad_Textblock.Visibility = Visibility.Hidden;
                }
                else
                    edad_Textblock.Visibility = Visibility.Visible;
                
            }
        }
    }
}
