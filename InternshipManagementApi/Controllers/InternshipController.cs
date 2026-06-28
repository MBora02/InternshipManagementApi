using InternshipManagementApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternshipManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternshipController : ControllerBase
    {
        private readonly AppDbContext _context;
        public InternshipController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetInternship")]
        public async Task<IEnumerable<Internship>> GetInternship()
        {
            return await _context.Internships.ToListAsync();
        }

        [HttpPost]
        [Route("AddInternship")]
        public async Task<Internship> AddInternship(Internship internship)
        {
            _context.Internships.Add(internship);
            await _context.SaveChangesAsync();
            return internship;
        }

        [HttpPut]
        [Route("UpdateInternship/{id}")]
        public async Task<Internship> UpdateInternship(Internship internship, int id)
        {

            _context.Entry(internship).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return internship;
        }

        [HttpDelete]
        [Route("DeleteInternship/{id}")]
        public async Task<IActionResult> DeleteInternship(int id)
        {
            var internship = await _context.Internships.FindAsync(id);
            if (internship == null)
            {
                return NotFound();
            }
            _context.Internships.Remove(internship);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        //public bool DeleteInternship(int id)
        //{
        //    bool a = false;
        //    var internship = _context.Internships.Find(id);
        //    if (internship != null)
        //    {
        //        a = true;
        //        _context.Internships.Remove(internship);
        //        _context.SaveChangesAsync();
        //    }
        //    else
        //    {
        //        a = false;
        //    }
        //    return a;
        //}
    }
}
