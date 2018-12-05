﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASample.SignalRNet.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var chatGuid = Guid.NewGuid().ToString("N");
            ViewBag.ClientName = "聊客-" + chatGuid;
            var onLineUserList = Core.ChatHub.OnLineUsers.Select(u => new SelectListItem() { Text = u.Value, Value = u.Key }).ToList();
            onLineUserList.Insert(0, new SelectListItem() { Text = "-所有人-", Value = "" });
            ViewBag.OnLineUsers = onLineUserList;
            return View();
        }
    }
}
