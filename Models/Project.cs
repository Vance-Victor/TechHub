namespace TechHub.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string? Deadline { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public Department? Department { get; set; }
    }
}
