using System.Linq;
using Crr.Models.Term;
using Crr.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crr.Controllers
{
    public class TermController : Controller
    {
        private readonly ITermService _termService;
        public TermController(ITermService termService)
        {
            _termService = termService;
        }

        [Route("what-is")]
        public IActionResult Index()
        {   

            var terms = _termService.GetAll()
                .Select(term => new TermModel
                {
                    LinkName = term.LinkName,
                    Name = term.Name,
                    Description = term.Description,
                    ImageUrl = term.ImageUrl
                });

            var model = new TermIndexModel
            {
                TermList = terms
            };

            return View(model);
        }

        [Route("what-is/{linkName}")]
        public IActionResult Topic(string linkName)
        {
            var term = _termService.GetById(linkName);

            var model = new TermModel
            {
                LinkName = term.LinkName,
                Name = term.Name,
                Description = term.Description,
                ImageUrl = term.ImageUrl
            };

            return View(model);
        }

    }
}