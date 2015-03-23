using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DomacRad
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
       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.left_button.Click += new RoutedEventHandler(left_button_Click);
            this.right_button.Click += new RoutedEventHandler(right_button_Click);
            this.textBox1.MouseDoubleClick += new MouseButtonEventHandler(textBox1_MouseDoubleClick);
        }

        void textBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.textBox1.Clear();
        }

        void right_button_Click(object sender, RoutedEventArgs e)
        {
            var element = new Rectangle()
            {
                Width = 360,
                Height = 40,
                Fill = _GetRandomBrush(),
                Margin = new Thickness(5)
            };
            this.rectangleContainer.Children.Add(element);
        }

        void left_button_Click(object sender, RoutedEventArgs e)
        {
            var element = new Rectangle()
            {
                Width=70,
                Height=70,
                Fill=_GetRandomBrush(),
                Margin=new Thickness(5)
            };
            this.quadratContainer.Children.Add(element);
        }
        private Brush _GetRandomBrush()
        {
            var random = new Random();

            var brushesType = typeof(Brushes);
            var properties = brushesType.GetProperties();

            var randomNumber = random.Next(properties.Length);

            return (Brush)properties[randomNumber].GetValue(null, null);        }

    }
}
