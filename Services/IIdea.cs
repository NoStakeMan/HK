using System.Collections.Generic;
using System.Threading.Tasks;
using HK.EntityModels;

namespace HK.Services
{
    public interface IIdea
    {
        Idea GetById(int ideaId);
        IEnumerable<Idea> GetAll();

        Task Create(Idea idea);
        Task Delete(int ideaId);
    }
}