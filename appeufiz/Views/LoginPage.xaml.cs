using appeufiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appeufiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        public async void TapGestureRecognizer_TappedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text=="123")
            {
                await Navigation.PushAsync(new ItemsPage());
            }
            else
            {
                await DisplayAlert("Ops...", "O usuario ou a senha está incorreta!", "Ok");
            }
        }
    }
}