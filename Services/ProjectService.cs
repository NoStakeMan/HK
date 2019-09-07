using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HK.Data;
using HK.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace HK.Services
{
    public class ProjectService : IProject
    {
        private readonly ApplicationDbContext _context;
        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(Project project)
        {
            _context.Add(project);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int projectId)
        {
            var project = GetById(projectId);
            _context.Remove(project);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects
                .Include(p => p.Requirements);
        }

        public Project GetById(int projectId)
        {
            return _context.Projects.Where( p => p.Id == projectId)
                .Include(p => p.Requirements)
                .First();
        }
    }
}