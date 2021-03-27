using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GJUAntp.web.Controllers
{
    public class ExaminationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
