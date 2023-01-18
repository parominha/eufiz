using appeufiz.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace appeufiz.Views
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