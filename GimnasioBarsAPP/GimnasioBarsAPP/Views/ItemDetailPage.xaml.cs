using System.ComponentModel;
using GimnasioBarsAPP.ViewModels;
using Xamarin.Forms;

namespace GimnasioBarsAPP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}