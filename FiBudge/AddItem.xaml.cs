using System;
using FiBudge.Models;

using Xamarin.Forms;

namespace FiBudge
{
    public partial class AddItem : ContentPage
    {
        public AddItem()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var item = (Item)BindingContext;

            if (string.IsNullOrWhiteSpace(item.ItemName))
            {
                await DisplayAlert("Alert", "You didn't name the item", "OK");
            }else if (float.IsNaN(item.Amount))
            {
                await DisplayAlert("Alert", "You didn't give a valid amount", "OK");
            }
            else
            {
                await Navigation.PopAsync();
            }

            
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}