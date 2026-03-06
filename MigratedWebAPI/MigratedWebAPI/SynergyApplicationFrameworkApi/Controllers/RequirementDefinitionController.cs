using Microsoft.AspNetCore.Mvc;
using SynergyApplicationFrameworkApi.Application.Services;
using SynergyApplicationFrameworkApi.Application.DTOs;
using SynergyApplicationFrameworkApi.Application.Interfaces;
using SynergyApplicationFrameworkApi.Infrastructure.Repositories;

namespace SynergyApplicationFrameworkApi.Controllers;

/// <summary>
/// RequirementDefinition API Controller
/// Provides REST endpoints for RequirementDefinition operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class RequirementDefinitionController : ControllerBase
{
    private readonly ILogger<RequirementDefinitionController> _logger;
    
    /// <summary>
    /// Initializes a new instance of RequirementDefinitionController
    /// </summary>
    public RequirementDefinitionController(ILogger<RequirementDefinitionController> logger)
    {
        _logger = logger;
    }
}

}
