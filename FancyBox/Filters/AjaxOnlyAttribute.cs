using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FancyBox.Filters
{
    public class AjaxOnlyAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(!filterContext.HttpContext.Request.IsAjaxRequest())
                filterContext.Result = new HttpNotFoundResult();
        }

    }
}