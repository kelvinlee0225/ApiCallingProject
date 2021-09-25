using ApiCallingProject.Models;
using ApiCallingProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ApiCallingProject.ViewModels
{
    public class AnimeSongViewModel : BaseViewModel
    {
        public ObservableCollection<AnimeSong> AnimeSongs { get; set; }
        public ICommand GetAnimeSongsList { get; }

        IAniAPIService _aniAPIService;
        public AnimeSongViewModel(IAniAPIService aniAPIService)
        {
            _aniAPIService = aniAPIService;
            GetAnimeSongsList = new Command(getAnimeSongsList);
        }
        private async void getAnimeSongsList()
        {
            var networkConnection = Connectivity.NetworkAccess;
            if (networkConnection == NetworkAccess.Internet)
            {
                var animeSongResponse = await _aniAPIService.getAnimeSongListAsync();
                AnimeSongs = new ObservableCollection<AnimeSong>(animeSongResponse.Data.AnimeSongs);
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "You should be connected to a network for the app to work", "Ok");
            }
        }

    }
}
