using InvoiceGenerator.Infrastructure.Repository.BuyerRepository;
using InvoiceGenerator.InvoiceData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows;
using InvoiceGenerator.Infrastructure.Repository.InvoiceDetailsRepository;
using InvoiceGenerator.Infrastructure.Repository.SellerRepository;

namespace InvoiceGenerator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<InvocieContex>
                (options => options.UseSqlServer(Configuration.GetConnectionString("InvoiceDataBase")));
            services.AddTransient(typeof(MainWindow));
            services.AddTransient<IBuyerRepository, BuyerRepository>();
            services.AddTransient<ISellerRepository, SellerRepository>();
            services.AddTransient<IInvoiceDetailsRepository, InvoiceDetailsRepository>();

        }
    }
}

