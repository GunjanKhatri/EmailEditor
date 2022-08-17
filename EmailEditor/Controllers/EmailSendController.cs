using EmailEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace EmailEditor.Controllers
{
    public class EmailSendController : Controller
    {
        // GET: EmailSend
        public ActionResult Index()
        {
            using(EMSEntities ems =new EMSEntities())
            {
                var template = ems.EmailTemplates.Where(y => y.Id == 1).FirstOrDefault();
                var data = new StringBuilder(template.Body);
                data.Replace("", "");
                data.Replace("", "");
                data.Replace("", "");
            }
            return View();
        }


    }
}