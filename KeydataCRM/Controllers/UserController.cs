using BusinessLayer.Concrete;
using System.Collections.Generic;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KeydataCRM.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EFUserDal());
        ProjectManager pm = new ProjectManager(new EFProjectDal());
        public IActionResult Index()
        {
            var uservalues = um.GetAll();
            return View(uservalues);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User p)
        {
            um.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var uservalue = um.TGetById(id);
            um.TRemove(uservalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var uservalue = um.TGetById(id);
            return View(uservalue);
        }

        [HttpPost]
        public IActionResult EditUser(User user)
        {
            um.TUpdate(user);
            return RedirectToAction("Index");
        }

        
        public IActionResult UserProject(int id) 
        {
            var uservalue = um.TGetById(id);
            var projectvalue = pm.GetAll().Where(x => x.ProjectStatus == true && x.UserID == id).ToList();
            return View(projectvalue);
        }

        
       
    }
}
