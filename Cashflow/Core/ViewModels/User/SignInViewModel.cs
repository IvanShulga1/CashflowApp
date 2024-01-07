using System;
using CommunityToolkit.Mvvm.Input;

namespace Core.ViewModels.User
{
	public class SignInViewModel : BaseViewModel
    {
        public RelayCommand SignInCommand { get; }

        public SignInViewModel()
		{
            SignInCommand = new RelayCommand(OnSignIn);

        }

        private void OnSignIn()
        {
            // logic
        }
    }
}

