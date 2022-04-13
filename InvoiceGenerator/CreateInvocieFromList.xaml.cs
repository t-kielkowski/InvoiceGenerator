using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using InvoiceGenerator.Infrastructure.Repository.BuyerRepository;
using InvoiceGenerator.Infrastructure.Repository.SellerRepository;
using InvoiceGenerator.InvoiceData;
using InvoiceGenerator.Mapping;

namespace InvoiceGenerator
{
    /// <summary>
    /// Logika interakcji dla klasy CreateInvocieFromList.xaml
    /// </summary>
    public partial class CreateInvocieFromList : Window
    {
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;

        public List<Buyer> BuyerList { get; set; }
        public List<Seller> SellerList { get; set; }
        public List<string> ComboBoxBuyerList { get; set; }
        public List<string> ComboBoxSellerList { get; set; }

        public CreateInvocieFromList(IBuyerRepository buyerRepository, ISellerRepository sellerRepository)
        {
            InitializeComponent();

            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
            _sellerRepository = sellerRepository ?? throw new ArgumentNullException(nameof(sellerRepository));
            DataContext = this;

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            BuyerList = _buyerRepository.GetAllAsync();
            ComboBoxBuyerList = BuyerList.Select(x => $"{x.Name} {x.SecondName}").ToList();
            ComBoxListOfBuyers.SelectedIndex = 0;

            SellerList = _sellerRepository.GetAllAsync();
            ComboBoxSellerList = SellerList.Select(x => $"{x.Name} {x.SecondName}").ToList();
            ComBoxListOfSellers.SelectedIndex = 0;
        }

        private void ComBoxListOfBuyers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentItem = ComBoxListOfBuyers.SelectedItem.ToString();

            var selectedItem = BuyerList
                .FirstOrDefault(x => $"{x.Name} {x.SecondName}" == currentItem);
            txtBlockBuyerData.Text = selectedItem.Extend().FullDataString;
        }

        private void ComBoxListOfSellers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentItem = ComBoxListOfSellers.SelectedItem.ToString();

            var selectedItem = SellerList
                .FirstOrDefault(x => $"{x.Name} {x.SecondName}" == currentItem);
            txtBlockSellerData.Text = selectedItem.Extend().FullDataString;
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
