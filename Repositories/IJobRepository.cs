using JobTracker.Models;

namespace JobTracker.Repositories
{
    public interface IJobRepository
    {
        Task<IEnumerable<JobApplication>> GetAllAsync();
       // Task<JobApplication?> GetByIdAsync(int id);
        Task AddAsync(JobApplication application);
        //Task UpdateAsync(JobApplication application);
        //Task DeleteAsync(int id);
    }
}
