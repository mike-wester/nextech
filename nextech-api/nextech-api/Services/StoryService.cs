using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using nextech_api.Interfaces.Services;
using nextech_api.Models;

namespace nextech_api.Services
{
	public class StoryService : IStoryService
	{
		public readonly HttpClient _httpClient;
        public readonly IMemoryCache _memoryCache;

        const string STORIES_API = "https://hacker-news.firebaseio.com/v0/beststories.json";
        const string STORY_API = "https://hacker-news.firebaseio.com/v0/item/{0}.json";

        public StoryService(HttpClient httpClient, IMemoryCache memoryCache)
		{
			_httpClient = httpClient;
            _memoryCache = memoryCache;
        }
        
		public async Task<IEnumerable<Story>> GetStories()
		{
            List<Story> stories = new List<Story>();
            IEnumerable<Task<Story>> storyTasks;

            using HttpResponseMessage response = await _httpClient.GetAsync(STORIES_API);

			if(response.IsSuccessStatusCode)
			{
                var storiesResponse = response.Content.ReadAsStringAsync().Result;
                var storiesAPI = JsonConvert.DeserializeObject<List<int>>(storiesResponse);

                storyTasks = storiesAPI?.Select(GetStory);
                stories = (await Task.WhenAll(storyTasks)).ToList();
            }

            return stories;
        }
        

        public async Task<Story> GetStory(int storyId)
        {
            return await _memoryCache.GetOrCreateAsync<Story>(storyId,
                async cacheEntry => {
                    Story story = new Story();

                    var response = await _httpClient.GetAsync(string.Format(STORY_API, storyId));
                    if (response.IsSuccessStatusCode)
                    {
                        var storyResponse = response.Content.ReadAsStringAsync().Result;

                        if (storyResponse != null)
                        {
                            story = JsonConvert.DeserializeObject<Story>(storyResponse);
                        }
                    }

                    return story;
                });
        }
    }
}

