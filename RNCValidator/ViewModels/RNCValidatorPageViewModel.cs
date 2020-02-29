using System;
using System.ComponentModel;
using System.Windows.Input;
using RNCValidator.Models;
using RNCValidator.Services;
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
            this.Contributor = await _apiService.GetContributorAsync(RNC);
            HasContributor = this.Contributor != null;

        }

    }
}
