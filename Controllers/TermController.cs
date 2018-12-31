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
    }
}