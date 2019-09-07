using System.Linq;
using HK.Models.Project;
using HK.Services;
using Microsoft.AspNetCore.Mvc;

namespace HK.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProject _projectService;
        public ProjectController(IProject projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var projects = _projectService.GetAll()
                            .Select( p => new ProjectViewModel {
                                Id = p.Id,
                                Title = p.Title,
                                Content = p.Content,
                                Status = p.Status
                            });

            var model = new ProjectListingViewModel {
                ProjectList = projects
            };

            return View(model);
        }
    }
}