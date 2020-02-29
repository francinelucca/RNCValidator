using System;
using System.ComponentModel;
using System.Windows.Input;
using RNCValidator.Models;
using RNCValidator.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RNCValidator.ViewModels
{
    public class RNCValidatorPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        IApiService _apiService = new ApiService();

        public string RNC { get; set; }

        public Contributor Contributor { get; set; }

        public bool HasContributor { get; set; }

        public ICommand GetRNCCommand { get; set; }

        public RNCValidatorPageViewModel()
        {
            Contributor = new Contributor();

            GetRNCCommand = new Command(GetRNC);

        }


        public async void GetRNC()
        {
            try
            {
                HasContributor = false;
                if(Connectivity.NetworkAccess != NetworkAccess.Internet)
                {
                    await App.Current.MainPage.DisplayAlert("No Internet Connection", "Can not get RNC information because there is no internet connection available. Please connect to the internet and try again.", "OK");
                    return;
                }
                this.Contributor = await _apiService.GetContributorAsync(RNC);
                HasContributor = this.Contributor != null;
            }
            catch(Exception e)
            {
                await App.Current.MainPage.DisplayAlert("An Error Occured", e.Message , "OK");
            }

        }

    }
}
