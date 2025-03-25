using System;

namespace BlazorRazden.App.Models
{
    public class IndexModel
    {
        public Guid ID { get; set; }
        public string? Description { get; set; }
        public string? IndexDate { get; set; }
        public double IndexValue { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
