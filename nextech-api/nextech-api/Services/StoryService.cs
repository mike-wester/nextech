using System;
using nextech_api.Interfaces.Services;

namespace nextech_api.Services
{
	public class StoryService : IStoryService
	{
		public readonly HttpClient _httpClient;

		public StoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task GetStories()
		{
			using HttpResponseMessage response = await _httpClient.GetAsync("https://hacker-news.firebaseio.com/v0/newstories.json");

			response.EnsureSuccessStatusCode();

			var jsonResponse = await response.Content.ReadAsByteArrayAsync();
            Console.WriteLine($"{jsonResponse}\n");

        }
	}
}

