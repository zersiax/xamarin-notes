using FromTheStart.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FromTheStart.Views
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