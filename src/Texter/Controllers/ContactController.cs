using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Texter.Models;

namespace Texter.Controllers
{
    public class ContactController : Controller
    {
        private TexterContext _db = new TexterContext();
       

        public ContactController(TexterContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Contacts.ToList());
        }

        public IActionResult ShowContactSave()
        {
            return View();
        }
    }
}
