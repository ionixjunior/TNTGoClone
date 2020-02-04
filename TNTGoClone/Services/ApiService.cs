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
			_api = RestService.For<IApi>("https://tntgo.getsandbox.com");
		}

		public async Task<IList<Live>> GetLives()
		{
			return await _api.GetLives();
		}

		public async Task<IList<Movie>> GetMovies()
		{
			return await _api.GetMovies();
		}
	}
}
