using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KeydataCRM.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EFProjectDal());
        public IActionResult Index()
        {
            var projectvalues= pm.GetAll().Where(x => x.ProjectStatus == false);
            return View(projectvalues);
        }
    }
}
