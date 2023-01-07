﻿using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Web.Mvc;

namespace RF.Modules.TestFlightAppointment.Controllers
{
    [DnnHandleError]
    public class TestFlightGridController : DnnController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}