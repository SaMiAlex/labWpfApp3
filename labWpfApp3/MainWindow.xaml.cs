using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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


namespace labWpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textbox != null)
            {
                textbox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontHeight = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textbox != null)
            {
                textbox.FontSize = fontHeight;
            }

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (textbox != null)
            {
                if (textbox.FontWeight != FontWeights.Bold)
                {
                    textbox.FontWeight = FontWeights.Bold;
                }
                else
                {
                    textbox.FontWeight = FontWeights.Normal;
                }
            }
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

            if (textbox != null)
            {
                if (textbox.FontStyle != FontStyles.Italic)
                {
                    textbox.FontStyle = FontStyles.Italic;
                }
                else
                {
                    textbox.FontStyle = FontStyles.Normal;
                }
            }
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            if (textbox != null)
            {
                if (textbox.TextDecorations != TextDecorations.Underline)
                {
                    textbox.TextDecorations = TextDecorations.Underline;
                }
                else
                {
                    textbox.TextDecorations = TextDecorations.Baseline;//не нашел как убрать подчеркивание                    
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textbox != null)
            {
                textbox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textbox != null)
            {
                textbox.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textbox.Text);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
