namespace InternshipManagementApi.Models
{
    public class Internship
    {
        public int InternshipId { get; set; }
        public string StudentName { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Status { get; set; }
    }
}
