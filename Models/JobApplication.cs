namespace JobTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string status { get; set; } = "Applied";
        public DateTime DateApplied { get; set; } = DateTime.UtcNow;
        public string? JobUrl {get; set;}
        public string? Notes { get; set; }
    }
}
