using Microsoft.AspNetCore.Mvc;
using SynergyApplicationFrameworkApi.Application.Services;
using SynergyApplicationFrameworkApi.Application.DTOs;
using SynergyApplicationFrameworkApi.Application.Interfaces;
using SynergyApplicationFrameworkApi.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;

namespace SynergyApplicationFrameworkApi.Controllers
{
    /// <summary>
    /// Controller for handling base service operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceBaseController : ControllerBase
    {
        private readonly ICacheManager _cacheManager;
        private readonly ITranslator _translator;
        private readonly ILogger<ServiceBaseController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceBaseController"/> class.
        /// </summary>
        /// <param name="cacheManager">The cache manager.</param>
        /// <param name="translator">The translator.</param>
        /// <param name="logger">The logger.</param>
        public ServiceBaseController(ICacheManager cacheManager, ITranslator translator, ILogger<ServiceBaseController> logger)
        {
            _cacheManager = cacheManager ?? throw new ArgumentNullException(nameof(cacheManager));
            _translator = translator ?? throw new ArgumentNullException(nameof(translator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Gets the cache manager.
        /// </summary>
        /// <returns>The cache manager.</returns>
        [HttpGet("CacheManager")]
        public ActionResult<ICacheManager> GetCacheManager()
        {
            try
            {
                _logger.LogInformation("Attempting to retrieve CacheManager.");
                return Ok(_cacheManager);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving CacheManager.");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Gets the translator.
        /// </summary>
        /// <returns>The translator.</returns>
        [HttpGet("Translator")]
        public ActionResult<ITranslator> GetTranslator()
        {
            try
            {
                _logger.LogInformation("Attempting to retrieve Translator.");
                return Ok(_translator);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Translator.");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Disposes of the resources used by the controller.
        /// </summary>
        [HttpDelete("Dispose")]
        public IActionResult DisposeController()
        {
            try
            {
                _logger.LogInformation("Disposing ServiceBaseController.");
                // No resources to dispose in this example, but you can add disposal logic here if needed.
                return Ok("Controller disposed.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error disposing ServiceBaseController.");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
