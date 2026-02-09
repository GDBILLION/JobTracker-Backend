using System.ComponentModel.DataAnnotations;

namespace JobTracker.DTOs
{
    public class CreateJobApplicationDto
    {
        [Required]
        [StringLength(100)]

        public string CompanyName { get; set; } = string.Empty;

        [Required]
        public string JobTitle { get; set; } = string.Empty;

        public string? JobUrl { get; set; }
    }
}
