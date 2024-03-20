using Data.Models;
using Data.Ports;
using Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RedYellowAPI.Controllers
{
    [ApiController]
    [Route("api/applicant")]
    public class RegistrationController : ControllerBase
    {
       
        private readonly ILogger<RegistrationController> _logger;
        private readonly IApplicantDatabasePort _applicantDatabasePort;

        public RegistrationController(ILogger<RegistrationController> logger, IApplicantDatabasePort applicantDatabasePort)
        {
            _logger = logger;
            _applicantDatabasePort = applicantDatabasePort;
        }

        [HttpGet(Name = "GetCourses")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("register")]
        public async Task<IActionResult> AddApplicant(Applicant applicant, CancellationToken cancellationToken)
        {
            var result = await _applicantDatabasePort.AddApplicant(applicant, cancellationToken);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateApplicant(Applicant applicant, CancellationToken cancellationToken)
        {
            var result = await _applicantDatabasePort.UpdateApplicant(applicant, cancellationToken);
            return Ok(result);
        }

        [HttpGet("id-number/{idNumber}")]
        public async Task<IActionResult> IdNumberValidationCheck(string idNumber)
        {
            return Ok(await _applicantDatabasePort.IdNumberValidationCheck(idNumber));
        }
    }
}
