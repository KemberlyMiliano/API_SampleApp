using APISampleApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APISampleApp.Services
{
    public interface IApiServiceRefit
    {
        [Get(Constants.RelativeUrl)]
        Task<RandomBeer> GetRandomBeerRefit();
    }
}
