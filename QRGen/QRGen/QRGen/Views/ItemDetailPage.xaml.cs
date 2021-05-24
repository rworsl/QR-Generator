using QRGen.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace QRGen.Views
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