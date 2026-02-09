using JobTracker.DTOs;
using JobTracker.Models;
using JobTracker.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly IJobRepository _repository;

        public ApplicationsController(IJobRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        // GET: api/v1/applications
        public async Task<ActionResult<IEnumerable<JobApplicationResponseDto>>> GetJobs()
        {
            var jobs = await _repository.GetAllAsync();

            var response = jobs.Select(job => new JobApplicationResponseDto
            {
                Id = job.Id,
                CompanyName = job.CompanyName,
                JobTitle = job.JobTitle,
                Status = job.status,
                DateApplied = job.DateApplied.ToString("yyyy-MM-dd")
            });
            return Ok(response);
        }
        [HttpPost]
        // POST: api/v1/applications

        public async Task<ActionResult<JobApplicationResponseDto>> CreateJob(CreateJobApplicationDto createDto)
        {
            // Transform Request DTO -> Entity
            var newJob = new JobApplication
            {
                CompanyName = createDto.CompanyName,
                JobTitle = createDto.JobTitle,
                JobUrl = createDto.JobUrl,
                status = "Applied",
                DateApplied = DateTime.UtcNow
            };

            await _repository.AddAsync(newJob);

            // Return the Response DTO
            return CreatedAtAction(nameof(GetJobs), new { id = newJob.Id }, new JobApplicationResponseDto
            {
                Id = newJob.Id,
                CompanyName = newJob.CompanyName,
                JobTitle = newJob.JobTitle,
                Status = newJob.status,
            });
        }
    }
}
