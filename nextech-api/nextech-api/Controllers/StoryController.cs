using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using nextech_api.Interfaces.Services;
using nextech_api.Services;

namespace nextech_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoryController : Controller
{
    private readonly ILogger<StoriesController> _logger;
    private readonly IStoryService _storyService;

    public StoryController(ILogger<StoriesController> logger, IStoryService storyService)
    {
        _logger = logger;
        _storyService = storyService;

    }

    [HttpGet]
    public async Task<object> GetStory(int Id)
    {
        return await _storyService.GetStory(Id);
    }
}
