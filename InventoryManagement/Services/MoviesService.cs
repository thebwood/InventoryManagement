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
            var baseURL = "https://localhost:44349/";
            return await this.GetAPIResult<List<MoviesModel>>(baseURL, "api/movies");
        }

        public async Task<MoviesModel> GetMovie(long movieId)
        {
            var baseURL = "https://localhost:44349/";
            return await this.GetAPIResult<MoviesModel>(baseURL, "api/movies/" + movieId.ToString());
        }


        public async Task<List<string>> SaveMovie(MoviesModel movie)
        {
            var baseURL = "https://localhost:44349/";
            return await this.PostAPIResult<MoviesModel>(baseURL, "api/movies/", movie);
        }

    }
}
