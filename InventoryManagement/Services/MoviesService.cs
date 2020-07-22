using InventoryManagement.Models.Movies;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public class MoviesService : BaseService
    {
        HttpClient Http = new HttpClient();

        public Task<List<MoviesModel>> GetMovies()
        {
            return Http.GetFromJsonAsync<List<MoviesModel>>("api/movies");
        }
    }
}
