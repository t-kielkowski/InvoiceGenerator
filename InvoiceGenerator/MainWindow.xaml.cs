using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;

namespace InvoiceGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private const double _windowReductionFactor = 3;
        //private double _heightWindowAfterScaling = SystemParameters.PrimaryScreenHeight / _windowReductionFactor;
        //private double _widthWindowAfterScaling = SystemParameters.PrimaryScreenWidth / _windowReductionFactor;
        private const double HeightWindowAfterScaling = 600;
        private const double WidthWindowAfterScaling = 800;

        public MainWindow()
        {
            InitializeComponent();
            this.Height = HeightWindowAfterScaling;
            this.Width = WidthWindowAfterScaling;
        }

        private void ButtonAddFromList(object sender, RoutedEventArgs e)
        {

        }
    }
}
