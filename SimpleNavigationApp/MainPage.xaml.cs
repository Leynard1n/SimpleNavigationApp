﻿using Microsoft.Maui.Controls;

namespace SimpleNavigationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }
    }
}