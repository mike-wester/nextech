﻿using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using nextech_api.Interfaces.Services;
using nextech_api.Services;

namespace nextech_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoriesController : Controller
{
    private readonly ILogger<StoriesController> _logger;
    private readonly IStoryService _storyService;

    public StoriesController(ILogger<StoriesController> logger, IStoryService storyService)
    {
        _logger = logger;
        _storyService = storyService;

    }

    [HttpGet]
    public async Task<object> GetStories()
    {
        return await _storyService.GetStories();
    }
}
