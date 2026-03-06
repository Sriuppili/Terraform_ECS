using Microsoft.AspNetCore.Mvc;
using SynergyApplicationFrameworkApi.Application.Services;
using SynergyApplicationFrameworkApi.Application.DTOs;
using SynergyApplicationFrameworkApi.Application.Interfaces;
using SynergyApplicationFrameworkApi.Infrastructure.Repositories;

namespace SynergyApplicationFrameworkApi.Controllers;

/// <summary>
/// Requirement API Controller
/// Provides REST endpoints for Requirement operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class RequirementController : ControllerBase
{
    private readonly ILogger<RequirementController> _logger;
    
    /// <summary>
    /// Initializes a new instance of RequirementController
    /// </summary>
    public RequirementController(ILogger<RequirementController> logger)
    {
        _logger = logger;
    }
}

}
