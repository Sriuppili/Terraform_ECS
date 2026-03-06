using Microsoft.AspNetCore.Mvc;
using SynergyApplicationFrameworkApi.Application.Services;
using SynergyApplicationFrameworkApi.Application.DTOs;
using SynergyApplicationFrameworkApi.Application.Interfaces;
using SynergyApplicationFrameworkApi.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SynergyApplicationFrameworkApi.Controllers
{
    /// <summary>
    /// Controller for managing Container Instance Automatic Events.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ContainerInstanceAutomaticEventController : ControllerBase
    {
        private readonly IAutomaticEventService _automaticEventService;
        private readonly IPathwayRepository _pathwayRepository;
        private readonly ILogger<ContainerInstanceAutomaticEventController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerInstanceAutomaticEventController"/> class.
        /// </summary>
        /// <param name="automaticEventService">The automatic event service.</param>
        /// <param name="pathwayRepository">The pathway repository.</param>
        /// <param name="logger">The logger.</param>
        public ContainerInstanceAutomaticEventController(IAutomaticEventService automaticEventService, IPathwayRepository pathwayRepository, ILogger<ContainerInstanceAutomaticEventController> logger)
        {
            _automaticEventService = automaticEventService ?? throw new ArgumentNullException(nameof(automaticEventService));
            _pathwayRepository = pathwayRepository ?? throw new ArgumentNullException(nameof(pathwayRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Creates a new automatic event rule.
        /// </summary>
        /// <param name="request">The request containing the data for the new rule.</param>
        /// <returns>The ID of the newly created rule.</returns>
        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Create([FromBody] CreateAutomaticEventRuleRequest request)
        {
            try
            {
                if (request == null)
                {
                    _logger.LogError("Create request is null.");
                    return BadRequest("Request cannot be null.");
                }

                int newRuleId = _automaticEventService.Create(request, _pathwayRepository);
                _logger.LogInformation($"Automatic event rule created with ID: {newRuleId}");
                return Ok(newRuleId);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex, "ArgumentNullException in Create.");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating automatic event rule.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while creating the automatic event rule.");
            }
        }

        /// <summary>
        /// Reads automatic event rules based on the provided request.
        /// </summary>
        /// <param name="request">The request containing the filter criteria.</param>
        /// <returns>A list of automatic event details.</returns>
        [HttpPost]
        [Route("Read")]
        [ProducesResponseType(typeof(List<AutomaticEventDetailsDataContract>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Read([FromBody] ReadAutomaticEventRuleRequest request)
        {
            try
            {
                if (request == null)
                {
                    _logger.LogError("Read request is null.");
                    return BadRequest("Request cannot be null.");
                }

                List<AutomaticEventDetailsDataContract> automaticEventDetails = _automaticEventService.Read(request, _pathwayRepository);
                _logger.LogInformation($"Read {automaticEventDetails.Count} automatic event details.");
                return Ok(automaticEventDetails);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex, "ArgumentNullException in Read.");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error reading automatic event rules.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while reading automatic event rules.");
            }
        }

        /// <summary>
        /// Updates existing automatic event rules.
        /// </summary>
        /// <param name="requestList">A list of requests containing the updated data for the rules.</param>
        /// <returns>The number of rules updated.</returns>
        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Update([FromBody] List<UpdateAutomaticEventRuleRequest> requestList)
        {
            try
            {
                if (requestList == null || !requestList.Any())
                {
                    _logger.LogError("Update request list is null or empty.");
                    return BadRequest("Request list cannot be null or empty.");
                }

                int updatedCount = _automaticEventService.Update(requestList, _pathwayRepository);
                _logger.LogInformation($"Updated {updatedCount} automatic event rules.");
                return Ok(updatedCount);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex, "ArgumentNullException in Update.");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating automatic event rules.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating automatic event rules.");
            }
        }
    }
}
