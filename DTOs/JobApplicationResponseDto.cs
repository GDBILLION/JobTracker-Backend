namespace JobTracker.DTOs
{
    //The Response DTO (What we send to React)
    public class JobApplicationResponseDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string DateApplied { get; set; } = string.Empty;
    }
}
