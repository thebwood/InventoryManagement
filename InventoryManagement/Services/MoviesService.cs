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
        public async Task<List<MoviesModel>> GetMovies()
        {
            //var baseURL = Environment.GetEnvironmentVariable("MovieAPI");

            var baseURL = "https://localhost:44349/";
            return await this.GetAPIResult<List<MoviesModel>>(baseURL, "api/movies");
        }

        public async Task<MoviesModel> GetMovie(int movieId)
        {
            //var baseURL = Environment.GetEnvironmentVariable("MovieAPI");

            var baseURL = "https://localhost:44349/";
            return await this.GetAPIResult<MoviesModel>(baseURL, "api/movies/" + movieId.ToString());
        }




    }
}
