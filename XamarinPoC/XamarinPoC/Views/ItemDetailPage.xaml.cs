using System.ComponentModel;
using Xamarin.Forms;
using XamarinPoC.ViewModels;

namespace XamarinPoC.Views
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