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
using System.Windows.Shapes;
using InvoiceGenerator.Infrastructure.Repository.BuyerRepository;
using InvoiceGenerator.Infrastructure.Repository.SellerRepository;

namespace InvoiceGenerator
{
    /// <summary>
    /// Interaction logic for AddTradingPartner.xaml
    /// </summary>
    public partial class AddTradingPartner : Window
    {
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;
        public AddTradingPartner(IBuyerRepository buyerRepository, ISellerRepository sellerRepository)
        {
            InitializeComponent();

            _buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
            _sellerRepository = sellerRepository ?? throw new ArgumentNullException(nameof(sellerRepository));
        }
    }
}
