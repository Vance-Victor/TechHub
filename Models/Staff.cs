﻿namespace TechHub.Models
{
    public class Staff
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Department? Department { get; set; }
    }
}
