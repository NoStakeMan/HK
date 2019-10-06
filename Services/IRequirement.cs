using System.Collections.Generic;
using System.Threading.Tasks;
using HK.EntityModels;

namespace HK.Services
{
    public interface IRequirement
    {
        Requirement GetById(int requirementId);
        IEnumerable<Requirement> GetAll();

        Task Create(Requirement requirement);
        Task Delete(int requirementId);
    }
}