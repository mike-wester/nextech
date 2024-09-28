using System;
namespace nextech_api.Interfaces.Services
{
	public interface IStoryService
    {
        public Task<String> GetStories();
    }
}

