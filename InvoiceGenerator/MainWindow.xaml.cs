using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using InvoiceGenerator.Infrastructure.Repository.BuyerRepository;
using InvoiceGenerator.InvoiceData;
using Microsoft.EntityFrameworkCore;

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

        private IBuyerRepository _repo;

        public MainWindow(IBuyerRepository repo)
        {
            InitializeComponent();
            _repo = repo;

            CreateDB();
            this.Height = HeightWindowAfterScaling;
            this.Width = WidthWindowAfterScaling;
        }

        private void CreateDB()
        {
            var buyer = new Buyer()
            {
                Name = "SomeName",
                City = "Labambia",
                NIP = "645879642",
                PostalCode = "44-360",
                Street = "Street"
            };


            try
            {
                _repo.CreateAsync(buyer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void ButtonAddFromList(object sender, RoutedEventArgs e)
        {

        }
    }
}
