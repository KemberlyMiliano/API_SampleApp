using APISampleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APISampleApp.Services
{
    public interface IApiService
    {
        Task<RandomBeer> GetRandomBeerAsync();
    }
}
