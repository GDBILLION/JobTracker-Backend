using JobTracker.Data;
using JobTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Repositories
{
    public class JobRepository: IJobRepository
    {
        private readonly AppDbContext _context;
        public JobRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<JobApplication>> GetAllAsync()
            => await _context.JobApplications.ToListAsync();

        public async Task AddAsync(JobApplication application)
        {
            await _context.JobApplications.AddAsync(application);
            await _context.SaveChangesAsync();
        }
    }
}
