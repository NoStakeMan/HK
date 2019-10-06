using System.Linq;
using HK.Models.Idea;
using HK.Services;
using Microsoft.AspNetCore.Mvc;

namespace HK.Controllers
{
    public class IdeaController : Controller
    {
        private readonly IIdea _ideaService;
        public IdeaController(IIdea ideaService)
        {
            _ideaService = ideaService;
        }

        public IActionResult Index()
        {
            var ideas = _ideaService.GetAll()
                .Select( i => new IdeaViewModel
                {
                    Id = i.Id,
                    UserId = i.UserId,
                    Title = i.Title,
                    Content = i.Content,
                    CreatedDate = i.CreatedDate,
                    EstimatedLevel = i.EstimatedLevel,
                    Level = i.Level
                });
            
            var model = new IdeaIndexViewModel
            {
                Ideas = ideas
            };

            return View(model);
        }
    }
}