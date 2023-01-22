using System;
using System.Collections.Generic;
using System.ComponentModel;
using Truco.Models;
using Truco.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Truco.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}