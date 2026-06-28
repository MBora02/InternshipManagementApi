using InternshipManagementApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternshipManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CompanyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetCompany")]
        public async Task<IEnumerable<Company>> GetCompany()
        {
            return await _context.Companies.ToListAsync();
        }

        [HttpPost]
        [Route("AddCompany")]
        public async Task<Company> AddCompany(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return company;
        }

        [HttpPut]
        [Route("UpdateCompany/{id}")]
        public async Task<Company> UpdateCompany(Company company, int id)
        {

            _context.Entry(company).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return company;
        }

        [HttpDelete]
        [Route("DeleteCompany/{id}")]
        public bool DeleteCompany(int id)
        {
            bool a = false;
            var company = _context.Companies.Find(id);
            if (company != null)
            {
                a = true;
                _context.Companies.Remove(company);
                _context.SaveChangesAsync();
            }
            else
            {
                a = false;
            }
            return a;
        }
    }
}
