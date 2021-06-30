using System;
using System.Windows;

namespace Convertor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConverterDataBase DataConvert = new ConverterDataBase();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickСalculate(object sender, RoutedEventArgs e)
        {
            try
            {
                double fromNum;
                fromNum = Double.Parse(userdata.Text);

                if (fromNum < 0)
                {
                    Resul.Text = ("Введено некорректное число");
                }
                else
                {
                    Resul.Text = $"{CountResult(fromNum, Box_1.SelectedIndex, Box_2.SelectedIndex)}";
                }
            }
            catch
            {
                Resul.Text = ("Введено некорректное число");
            }
        }

        private double CountResult(double num, int fromType, int toType)
        {
            double res = num / DataConvert.fromMetresTo[fromType] * DataConvert.fromMetresTo[toType];
            return res;
        }
    }
}
