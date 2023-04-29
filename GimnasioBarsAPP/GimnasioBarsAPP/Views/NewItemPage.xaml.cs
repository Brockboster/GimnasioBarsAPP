using System;
using System.Collections.Generic;
using System.ComponentModel;
using GimnasioBarsAPP.Models;
using GimnasioBarsAPP.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GimnasioBarsAPP.Views
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