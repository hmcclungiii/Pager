using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Global_OEM_Parts.Models;
using System.Data.Entity;
using PagedList;

    public class MyPagerExampleController : Controller
    {
        MyModelContext context = new MyModelContext();

        public ViewResult Index(int? page)
        {
            var users = from u in context.MyModel select u;
            users = users.OrderBy(u => u.UserId);
            int pageSize = 20;
            int pageNumber = (page ?? 1);
            return View(users.ToPagedList(pageNumber, pageSize));
        }
    }
