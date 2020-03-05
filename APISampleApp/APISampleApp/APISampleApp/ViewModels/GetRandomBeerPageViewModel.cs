using APISampleApp.Models;
using APISampleApp.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace APISampleApp.ViewModels
{
    public class GetRandomBeerPageViewModel : INotifyPropertyChanged
    {
        IApiService _apiService = new ApiService();
        public RandomBeer randomBeer { get; set; } = new RandomBeer();

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GetDataCommand { get; set; }
        public GetRandomBeerPageViewModel()
        {
            GetDataCommand = new Command(async () =>
            {
                await GetDataAysnc();

            });

        }
        async Task GetDataAysnc()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    //CallApiRefit();
                    randomBeer = await _apiService.GetRandomBeerAsync();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert(Constants.NullMessage, Constants.AlertMessage, Constants.CancelMessage);
            }
        }

        async Task CallApiRefit()
        {
            var apiResponse = RestService.For<IApiServiceRefit>(Constants.BaseUrl);
            var beer = await apiResponse.GetRandomBeerRefit();
            randomBeer = beer;

        }
    }
}
