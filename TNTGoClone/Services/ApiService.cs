using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using TNTGoClone.Interfaces;
using TNTGoClone.Models;

namespace TNTGoClone.Services
{
	public class ApiService : IApi
	{
		private static ApiService _instance;
		public static ApiService Instance = _instance ?? (_instance = new ApiService());

		private readonly IApi _api;

		private ApiService()
		{
			_api = RestService.For<IApi>("https://gist.githubusercontent.com/ionixjunior/cc2382a3d3472d191e88dc93b652bac8/raw/1111c2afa437e89ae0f2f5c69d9f7415da8e5fb9");
		}

		public async Task<IList<Live>> GetLives()
		{
			return await _api.GetLives();
		}

		public async Task<IList<Movie>> GetMovies()
		{
			return await _api.GetMovies();
		}

        public async Task<IList<Show>> GetShows()
        {
			return await _api.GetShows();
        }

        public async Task<IList<Extra>> GetExtras()
        {
			return await _api.GetExtras();
        }
    }
}
