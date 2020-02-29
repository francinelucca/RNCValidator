using System;
using System.Threading.Tasks;
using RNCValidator.Models;

namespace RNCValidator.Services
{
    public interface IApiService
    {
        Task<Contributor> GetContributorAsync(string rnc);
    }
}
