using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace SimpleNavigationApp
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            var items = FakeDatabase.GetItems();
            ItemsCollectionView.ItemsSource = new ObservableCollection<Item>(items);
        }
    }
}