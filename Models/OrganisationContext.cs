using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TechHub.Models
{
    public class OrganisationContext : DbContext
    {
        public OrganisationContext(DbContextOptions<OrganisationContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffSkill> StaffSkill { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
