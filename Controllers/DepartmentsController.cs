using Microsoft.AspNetCore.Mvc;
using sistema_web.Models;

namespace sistema_web.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index() {
            List<Department> list = new List<Department>();
            list.Add(new Department(1, "Eletronics"));
            list.Add(new Department(2, "Fashion"));

            return View(list);
        }
    }
}