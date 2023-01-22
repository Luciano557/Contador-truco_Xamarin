using System.ComponentModel;
using Truco.ViewModels;
using Xamarin.Forms;

namespace Truco.Views
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