﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area(areaName:"Member")]

    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
