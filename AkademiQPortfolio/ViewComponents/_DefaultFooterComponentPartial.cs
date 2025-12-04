using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultFooterComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var footer = _context.Contacts.FirstOrDefault();
            return View(footer);
        }
    }
}
