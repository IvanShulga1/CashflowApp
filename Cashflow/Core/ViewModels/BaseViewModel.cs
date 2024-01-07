using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Core.ViewModels
{
	public class BaseViewModel : ObservableObject
    {
		public BaseViewModel()
		{
		}

        //[RelayCommand]
        //void AddTask()
        //{
        //    // Add task logic...
        //}

        public RelayCommand LolCommand { get; }

        public AsyncRelayCommand Lol2Command { get; }
    }
}

