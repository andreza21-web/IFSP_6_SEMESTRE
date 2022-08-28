using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tp01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Button_Ok(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin"&& txtPassword.Text == "@admin"){
                DisplayAlert("Autorizado", "Login Autorizado", "ok");
            }
            else
            {
                DisplayAlert("Usuario ou senha incorreto", "Login não autorizado", "ok");
            }
        }

        private void Button_Limpar(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        private void Button_Creditos(object sender, EventArgs e)
        {
            DisplayAlert("Criado por:", "Andreza e Lidiane", "ok");
        }

    }
}