using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.DataContext;
using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Controllers
{
    public class UserController : Controller
    {
        private readonly CrudDBContext _cruddbcontext; 

        public UserController(CrudDBContext crudDBContext)
        {
            _cruddbcontext = crudDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User u)
        {
            if (ModelState.IsValid)
            {
                //no errors in form
                //insert the record to DB via EF Core
                _cruddbcontext.Users.Add(u);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("Allusers");
            }
            return View("Index");
        }

        public IActionResult Allusers()
        {
            return View(_cruddbcontext.Users.ToList());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Edit(int id)
        //{
        //    return View();
        //} 

        public IActionResult Delete(int id)
        {
            return View();
        }

    }
}
