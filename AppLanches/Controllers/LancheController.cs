using AppLanches.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lanchRepository;

        public LancheController(ILancheRepository lanchRepository)
        {
            _lanchRepository = lanchRepository;
        }

        public IActionResult List()
        {
            var lanches = _lanchRepository.Lanches;
            return View(lanches);
        }
    }
}
