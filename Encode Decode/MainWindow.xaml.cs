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

namespace Encode_Decode
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

        private void EncodeButton_Click(object sender, RoutedEventArgs e)
        {
            //Vignere
            if (Vignere.IsChecked == true)
            {
                if (string.IsNullOrEmpty(EncodeText.Text))
                {
                    EncodeText.Text = "Text Eingeben";
                }
                else {
                    if (string.IsNullOrEmpty(KeyEncode.Text))
                    {
                        KeyEncode.Text = "Key Eingeben";
                    }
                    else
                    {
                        // V Encode starten

                        Programm programm = new Programm();
                        char[] result = programm.encodeKey(EncodeText.Text, KeyEncode.Text);

                        String finsih = new String(result);
                        DecodeText.Text = finsih;

                        EncodeText.Text = "";
                        KeyEncode.Text = "";
                    }
                }
                
            }
            else {
                //caesar
                if (string.IsNullOrEmpty(EncodeText.Text))
                {
                    EncodeText.Text = "Text Eingeben";
                }
                else
                {
                    Programm programm = new Programm();

                    char[] result = programm.encodeCaesar(EncodeText.Text);
                    string finish = new string(result);
                    DecodeText.Text = finish;

                    EncodeText.Text = "";
                }
            }
        }

        private void DecodeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Vignere.IsChecked == true)
            {
                //Vignere
                if (string.IsNullOrEmpty(DecodeText.Text))
                {
                    DecodeText.Text = "Text Eingeben";
                }
                else
                {
                    if (string.IsNullOrEmpty(KeyDecode.Text))
                    {
                        KeyDecode.Text = "Key Eingeben";
                    }
                    else
                    {
                        // V decode Starten
                        Programm programm= new Programm();
                        char[] result = programm.decodeKey(DecodeText.Text, KeyDecode.Text);

                        String finsih = new String(result);
                        EncodeText.Text= finsih;
                        DecodeText.Text = "";
                        KeyDecode.Text = "";
                    }
                }
            }
            else
            {
                //caesar
                if (string.IsNullOrEmpty(DecodeText.Text))
                {
                    DecodeText.Text = "Text Eingeben";
                }
                else
                {
                    Programm programm = new Programm();

                    char[] result = programm.decodeCaesar(DecodeText.Text);
                    string finish = new string(result);

                    EncodeText.Text = finish;
                    DecodeText.Text = "";
                }
            }
        }

        private void Caesar_Click(object sender, RoutedEventArgs e)
        {
            KeyEncode.Visibility = Visibility.Hidden;
            KeyDecode.Visibility = Visibility.Hidden;
            KeyTextDecode.Visibility = Visibility.Hidden;
            KeyTextEncode.Visibility = Visibility.Hidden;   
        }

        private void Vignere_Click(object sender, RoutedEventArgs e)
        {
            KeyEncode.Visibility = Visibility.Visible;
            KeyDecode.Visibility = Visibility.Visible;
            KeyTextDecode.Visibility = Visibility.Visible;
            KeyTextEncode.Visibility = Visibility.Visible;
        }
    }
}
