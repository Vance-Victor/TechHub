namespace TechHub.Models
{
    public class StaffSkill
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public Staff? Staff { get; set; }
        public Skill? Skill { get; set; }
    }
}
