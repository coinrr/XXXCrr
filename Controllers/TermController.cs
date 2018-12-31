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
            var terms = _termService.GetAll();
                
            
        }

    }
}