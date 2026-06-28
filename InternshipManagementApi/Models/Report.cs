namespace InternshipManagementApi.Models
{
    public class Report
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime ReportDate { get; set; }

        public string Status { get; set; }
    }
}
