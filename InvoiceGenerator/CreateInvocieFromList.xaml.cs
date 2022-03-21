using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using InvoiceGenerator.Infrastructure.Repository.BuyerRepository;
using InvoiceGenerator.Infrastructure.Repository.SellerRepository;
using InvoiceGenerator.InvoiceData;

namespace InvoiceGenerator
{
    /// <summary>
    /// Logika interakcji dla klasy CreateInvocieFromList.xaml
    /// </summary>
    public partial class CreateInvocieFromList : Window
    {
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;

        public IEnumerable<Buyer> ComboBoxBuyerList { get; set; }
        public IEnumerable<Seller> ComboBoxSellerList { get; set; }


        public CreateInvocieFromList(IBuyerRepository buyerRepository, ISellerRepository sellerRepository)
        {
            InitializeComponent();

            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
            _sellerRepository = sellerRepository ?? throw new ArgumentNullException(nameof(sellerRepository));

            LoadComboBoxData();
            DataContext = this;
        }

        private async void LoadComboBoxData()
        {
            ComboBoxBuyerList = await _buyerRepository.GetBuyerNameList();
            ComboBoxSellerList = await _sellerRepository.GetSellerNameList();
        }

        private void btnMoveOn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
