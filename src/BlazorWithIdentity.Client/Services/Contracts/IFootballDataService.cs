using BlazorWithIdentity.Shared.DTO.Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Client.Services.Contracts
{
    public interface IFootballDataService
    {
        Task<FootballResultDTO<FootballDataDTO>> GetFootballData();


      
    }
}
