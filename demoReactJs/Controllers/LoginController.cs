using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demoReactJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        //private readonly IUnitOfWork _repoDatabase;
        public LoginController()
        {
            //_repoDatabase = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
