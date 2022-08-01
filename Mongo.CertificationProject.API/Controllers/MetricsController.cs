using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mongo.CertificationProject.API.Dtos;
using Mongo.CertificationProject.API.Services;

namespace Mongo.CertificationProject.API.Controllers
{
    [ApiController]
    [Route("metrics")]
    public class MetricsController : ControllerBase
    {

        private readonly MetricsService metricsService;

        public MetricsController(MetricsService metricsService)
        {
            this.metricsService = metricsService;
        }

        [HttpGet("planes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PlaneMetricsDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPlaneMetrics()
        {
            var objDtos = await metricsService.GetPlaneMetrics();
            if (objDtos == null)
            {
                return NotFound();
            }
            return Ok(objDtos);
        }

    }
}
