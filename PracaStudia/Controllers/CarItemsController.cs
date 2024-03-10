using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracaStudia.Data;

namespace PracaStudia.Controllers
{
     
    public class CarItemsController : Controller
    {
        private ApplicationDbContext dbContext;

        public CarItemsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Authorize(Roles ="Admin,Worker")]
        public IActionResult Index()
        {
            var carItems = dbContext.CarItems.ToList();
            return View(carItems);
        }
    }
}
