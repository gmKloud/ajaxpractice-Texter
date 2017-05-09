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
        [HttpPost]
        public IActionResult NewContact(string newName, string newNumber)
        {
            Contact newContact = new Contact(newName, newNumber);
            _db.Contacts.Add(newContact);
            _db.SaveChanges();
            return Json(newContact);
        }

        //Get - Edit form
        public IActionResult EditShow(int id)
        {
            var thisContact = _db.Contacts.FirstOrDefault(c => c.Id == id);
            return View(thisContact);
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, string number)
        {
            Contact thisContact = _db.Contacts.FirstOrDefault(c => c.Id == id);
            thisContact.Name = name;
            thisContact.Number = number;
            _db.Entry(thisContact).State = EntityState.Modified;
            _db.SaveChanges();
            return Json(thisContact);
        }
    }
}
