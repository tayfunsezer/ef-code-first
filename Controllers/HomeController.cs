using CodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string   Index()
        {
            SchoolDbContext con = new SchoolDbContext();
            return con.Courses.Count().ToString();
        }

    }
}
