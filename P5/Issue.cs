using System;
namespace P5
{
    public class Issue
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Discoverer { get; set; }
        public string InitialDescription { get; set; }
        public int IssueStatusId { get; set; }
        public DateTime DiscoveryDate { get; set; }

    }
}
