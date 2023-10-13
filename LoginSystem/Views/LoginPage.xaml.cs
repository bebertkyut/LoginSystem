using LoginSystem.Viewmodels;
namespace LoginSystem.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
		 
    }
}