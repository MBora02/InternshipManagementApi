using InternshipManagementApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternshipManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ReportController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetReport")]
        public async Task<IEnumerable<Report>> GetReport()
        {
            return await _context.Reports.ToListAsync();
        }

        [HttpPost]
        [Route("AddReport")]
        public async Task<Report> AddReport(Report report)
        {
            _context.Reports.Add(report);
            await _context.SaveChangesAsync();
            return report;
        }

        [HttpPut]
        [Route("UpdateReport/{id}")]
        public async Task<Report> UpdateReport(Report report, int id)
        {

            _context.Entry(report).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return report;
        }

        [HttpDelete]
        [Route("DeleteReport/{id}")]
        public async Task<IActionResult> DeleteReport(int id)
        {
            var report = await _context.Reports.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }
            _context.Reports.Remove(report);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
