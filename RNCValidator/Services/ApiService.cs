﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RNCValidator.Models;

namespace RNCValidator.Services
{
    public class ApiService : IApiService
    {
        public async Task<Contributor> GetContributorAsync(string rnc)
        {
            Contributor contributor = null;
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(String.Format("https://api.marcos.do/rnc/{0}", rnc));
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                contributor = JsonConvert.DeserializeObject<Contributor>(responseString);
            }
            return contributor;
        }
    }
}
