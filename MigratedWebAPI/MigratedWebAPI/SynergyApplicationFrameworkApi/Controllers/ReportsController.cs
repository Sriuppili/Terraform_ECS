using Microsoft.AspNetCore.Mvc;
using SynergyApplicationFrameworkApi.Application.Services;
using SynergyApplicationFrameworkApi.Application.DTOs;
using SynergyApplicationFrameworkApi.Application.Interfaces;
using SynergyApplicationFrameworkApi.Infrastructure.Repositories;

namespace SynergyApplicationFrameworkApi.Controllers;

/// <summary>
/// Reports API Controller
/// Provides REST endpoints for Reports operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ReportsController : ControllerBase
{
    private readonly ILogger<ReportsController> _logger;
    
    /// <summary>
    /// Initializes a new instance of ReportsController
    /// </summary>
    public ReportsController(ILogger<ReportsController> logger)
    {
        _logger = logger;
    }
}

}
