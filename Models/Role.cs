namespace TechHub.Models
{
    public class Role
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Responsibility { get; set; }
        public Project? Project { get; set; }
        public Staff? Staff { get; set; }
    }
}
