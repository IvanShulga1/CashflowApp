using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Cashflow.Core.ViewModels
{
	public partial class CategoryViewModel : BaseViewModel
    {
		public CategoryViewModel()
		{
		}

		//Create, edit, delete commands
		[RelayCommand]
		private void Create()
		{

		}
	}
}

