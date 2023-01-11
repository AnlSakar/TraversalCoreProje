using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUSController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUSController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values= _contactUsService.TGetListContactUsByTrue();
            return View(values);
        }
    }
}
