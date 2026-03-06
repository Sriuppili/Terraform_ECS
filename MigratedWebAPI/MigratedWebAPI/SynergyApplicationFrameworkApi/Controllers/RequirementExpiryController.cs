using Microsoft.AspNetCore.Mvc;
using SynergyApplicationFrameworkApi.Application.Services;
using SynergyApplicationFrameworkApi.Application.DTOs;
using SynergyApplicationFrameworkApi.Application.Interfaces;
using SynergyApplicationFrameworkApi.Infrastructure.Repositories;

namespace SynergyApplicationFrameworkApi.Controllers;

/// <summary>
/// RequirementExpiry API Controller
/// Provides REST endpoints for RequirementExpiry operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class RequirementExpiryController : ControllerBase
{
    private readonly ILogger<RequirementExpiryController> _logger;
    
    /// <summary>
    /// Initializes a new instance of RequirementExpiryController
    /// </summary>
    public RequirementExpiryController(ILogger<RequirementExpiryController> logger)
    {
        _logger = logger;
    }
}

}
