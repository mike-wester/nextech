using System;
using nextech_api.Models;

namespace nextech_api.Interfaces.Services
{
	public interface IStoryService
    {
        public Task<IEnumerable<Story>> GetStories();

        public Task<Story> GetStory(int storyId);
    }
}

