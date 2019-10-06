using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HK.Data;
using HK.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace HK.Services
{
    public class IdeaService : IIdea
    {
        private readonly ApplicationDbContext _context;
        public IdeaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Create(Idea idea)
        {
            _context.Add(idea);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int ideaId)
        {
            var idea = GetById(ideaId);
            _context.Remove(idea);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Idea> GetAll()
        {
            return _context.Ideas
                .Include( i => i.Points);
        }

        public Idea GetById(int ideaId)
        {
            return _context.Ideas
                .Where( i => i.Id == ideaId)
                .Include( i => i.Points)
                .First();
        }
    }
}