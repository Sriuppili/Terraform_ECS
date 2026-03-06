using Microsoft.AspNetCore.Mvc;
using SynergyApplicationFrameworkApi.Application.Services;
using SynergyApplicationFrameworkApi.Application.DTOs;
using SynergyApplicationFrameworkApi.Application.Interfaces;
using SynergyApplicationFrameworkApi.Infrastructure.Repositories;

namespace SynergyApplicationFrameworkApi.Controllers;

/// <summary>
/// RequirementExpiryWindow API Controller
/// Provides REST endpoints for RequirementExpiryWindow operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class RequirementExpiryWindowController : ControllerBase
{
    private readonly ILogger<RequirementExpiryWindowController> _logger;
    
    /// <summary>
    /// Initializes a new instance of RequirementExpiryWindowController
    /// </summary>
    public RequirementExpiryWindowController(ILogger<RequirementExpiryWindowController> logger)
    {
        _logger = logger;
    }
}

}
