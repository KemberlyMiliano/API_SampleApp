using APISampleApp.Models;
using APISampleApp.Services;
using APISampleApp.ViewModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APISampleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetRandomBeerPage : ContentPage
    {
        public GetRandomBeerPage()
        {
            InitializeComponent();
            BindingContext = new GetRandomBeerPageViewModel();
        }

    }
}