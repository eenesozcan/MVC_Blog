using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        MessageManager mm = new MessageManager(new EfMessageDal());

        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }

        public PartialViewResult ContactPartial()
        {

            var count1 = cm.GetList().Count();
            ViewBag.countcontact = count1;

            var count2 = mm.GetListInbox().Count();
            ViewBag.countinbox = count2;

            var count3 = mm.GetListSendbox().Count();
            ViewBag.countsendbox = count3;

            //var draft = cm.GetList().Where(x => x.UserID == true).Count();
            //ViewBag.draft = draft;


            return PartialView();
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }

    }
}