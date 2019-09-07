using System.Collections.Generic;
using System.Threading.Tasks;
using HK.EntityModels;

namespace HK.Services
{
    public interface IProject
    {
        Project GetById(int projectId);
        IEnumerable<Project> GetAll();

        Task Create(Project project);
        Task Delete(int projectId);
        
    }
}