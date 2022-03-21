using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using InvoiceGenerator.Infrastructure.Repository.BuyerRepository;
using InvoiceGenerator.Infrastructure.Repository.SellerRepository;
using InvoiceGenerator.InvoiceData;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;

        //private const double _windowReductionFactor = 3;
        //private double _heightWindowAfterScaling = SystemParameters.PrimaryScreenHeight / _windowReductionFactor;
        //private double _widthWindowAfterScaling = SystemParameters.PrimaryScreenWidth / _windowReductionFactor;
        private const double HeightWindowAfterScaling = 360;
        private const double WidthWindowAfterScaling = 860;

        public MainWindow(IBuyerRepository buyerRepository, ISellerRepository sellerRepository)
        {
            InitializeComponent();
            _buyerRepository = buyerRepository;
            _sellerRepository = sellerRepository;

            this.Height = HeightWindowAfterScaling;
            this.Width = WidthWindowAfterScaling;
        }

        private void ButtonAddFromList(object sender, RoutedEventArgs e)
        {
            var windows = new CreateInvocieFromList(_buyerRepository, _sellerRepository);
            windows.ShowDialog();

        }
    }
}
