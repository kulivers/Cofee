using CoolCoffeeStore.App.Services;
using CoolCoffeeStore.Model;
using MahApps.Metro.Controls;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoolCoffeeStore.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView : MetroWindow
    {
        private Coffee selectedCoffee;
        public CoffeeOverviewView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            CoffeeDataService coffeeDataService = new CoffeeDataService();
            CoffeeListView.ItemsSource = coffeeDataService.GetAllCoffees();
        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCoffee = e.AddedItems[0] as Coffee;

            if (selectedCoffee == null)
                return;

            CoffeeIdLabel.Content = selectedCoffee.CoffeeId;
            CoffeeNameLabel.Content = selectedCoffee.CoffeeName;
            DescriptionLabel.Content = selectedCoffee.Description;
            PriceLabel.Content = selectedCoffee.Price;
            StockAmountLabel.Content = selectedCoffee.AmountInStock.ToString();
            FirstTimeAddedLabel.Content = selectedCoffee.FirstAddedToStockDate.ToShortDateString();

            var img = new BitmapImage();
            img.BeginInit();
            img.UriSource =
                new Uri("/CoolCoffeeStore.App;component/Images/coffee" + selectedCoffee.CoffeeId + ".jpg",
                    UriKind.Relative);
            img.EndInit();
            CoffeeImage.Source = img;
        }
    }
}
