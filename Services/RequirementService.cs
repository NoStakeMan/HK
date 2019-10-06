using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HK.Data;
using HK.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace HK.Services
{
    public class RequirementService : IRequirement
    {
        private readonly ApplicationDbContext _context;
        public RequirementService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(Requirement requirement)
        {
            _context.Add(requirement);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int requirementId)
        {
            var requirement = GetById(requirementId);
            _context.Remove(requirement);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Requirement> GetAll()
        {
            return _context.Requirements
                    .Include( r => r.Rewards)
                    .Include( r => r.Votes);
        }

        public Requirement GetById(int requirementId)
        {
            return _context.Requirements
                    .Where( r => r.Id == requirementId)
                    .Include( r => r.Rewards)
                    .Include( r => r.Votes)
                    .First();
        }
    }
}