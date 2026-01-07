using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult UpdateContact(int id = 1)
        {
            var values = _context.Contacts.Find(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult UpdateContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var values = _context.Contacts.Find(contact.ContactId);
                values.Address = contact.Address;
                values.Phone = contact.Phone;
                values.Email = contact.Email;
                values.WebSite = contact.WebSite;
                values.MapLocation = contact.MapLocation;
                _context.SaveChanges();
                TempData["Update"] = "Bilgiler başarıyla güncellendi!";
                return Redirect("/Contact/UpdateContact/1");
            }
            return View(contact);
            
        }
    }
}
