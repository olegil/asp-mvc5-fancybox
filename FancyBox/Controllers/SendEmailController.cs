using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FancyBox.Filters;
using FancyBox.Models;

namespace FancyBox.Controllers
{
    public class SendEmailController : Controller
    {
        //
        // GET: /Send/
        [AjaxOnly]
        [HttpGet]
        public ActionResult GetEmailForm()
        {
            var model = new SendEmailViewModel();

            if (Session["EmailAddress"] != null)
                model.EmailAddress = Session["EmailAddress"] as string;

            return PartialView(model);
        }

        [AjaxOnly]
        [HttpPost]
        public ActionResult SubmitEmailForm(SendEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Doing the save of the email address to session
                Session["EmailAddress"] = model.EmailAddress;

                //Processing of the email etc..

                return JavaScriptRedirect("Confirmation", "SendEmail");
            }

            return PartialView("EmailForm", model);
        }

        [HttpGet]
        public ActionResult Confirmation()
        {
            return View();
        }

        private ActionResult JavaScriptRedirect(string action, string controller, object routeData = null)
        {
            return JavaScript("window.location.href = '" + Url.Action(action, controller, routeData) + "';");
        }
    }
}