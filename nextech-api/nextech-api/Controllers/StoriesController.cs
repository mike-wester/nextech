using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using nextech_api.Interfaces.Services;
using nextech_api.Services;

namespace nextech_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoriesController : ControllerBase
{
    private readonly ILogger<StoriesController> _logger;
    private readonly IStoryService _storyService;

    public StoriesController(ILogger<StoriesController> logger, IStoryService storyService)
    {
        _logger = logger;
        _storyService = storyService;

    }
    
    [HttpGet(Name = "GetStories")]
    public async Task<object> GetStories()
    {
        return await _storyService.GetStories();
    }
    /*
    [HttpGet(Name = "{id}")]
    public async Task<object> GetStory(int Id)
    {
        return await _storyService.GetStory(Id);
    }
    */
}

