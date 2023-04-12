using Microsoft.AspNetCore.Mvc;
using OdinsPizzaJoint.Models;

namespace OdinsPizzaJoint.Controllers
{
    public class PiesController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PiesController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            ViewBag.CurrentCategory = "Cheese Pies";
            return View(_pieRepository.AllPies);
        }
    }
}
