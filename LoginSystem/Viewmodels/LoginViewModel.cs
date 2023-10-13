using System;
using System.ComponentModel;
using System.Windows.Input;
using LoginSystem.Model;

namespace LoginSystem.Viewmodels;

public class LoginViewModel : INotifyPropertyChanged
{
	private LoginRequestModel myloginRequestModel = new LoginRequestModel();
	public LoginRequestModel MyloginRequestModel
	{
		get 
		{ 
			return myloginRequestModel; 
		}
		set 
		{ 
			myloginRequestModel = value;
			OnPropertyChanged(nameof(MyloginRequestModel));
		}
	}
	public ICommand LoginCommand { get; }



	public LoginViewModel()
	{
		LoginCommand = new Command(PerformLoginOperation);
	}

    private async void PerformLoginOperation(object obj)
    {
		//perform API Operation/ DB Operation

		var data = MyloginRequestModel;
    }

    public event PropertyChangedEventHandler PropertyChanged;

	protected void OnPropertyChanged(string propertyName)
	{
		PropertyChanged?. Invoke(this, new PropertyChangedEventArgs(propertyName)); 
	}
}