﻿using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using nextech_api.Interfaces.Services;
using nextech_api.Services;

namespace nextech_api.Controllers;

[ApiController]
[Route("[controller]")]
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
    public async Task<object> GetAsync() => JsonConvert.DeserializeObject<List<int>>(await _storyService.GetStories());
}

