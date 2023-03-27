using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KeydataCRM.Controllers
{
    public class QuoteController : Controller
    {
        QuoteManager qm = new QuoteManager(new EFQuoteDal());
        public IActionResult Index()
        {
            var quotevalue = qm.GetAll();
            return View(quotevalue);
        }
    }
}
