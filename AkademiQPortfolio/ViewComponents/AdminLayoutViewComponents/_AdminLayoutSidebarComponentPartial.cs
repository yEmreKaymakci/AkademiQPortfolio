using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _AdminLayoutSidebarComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            int unreadCount = _context.Messages.Count(x => x.IsRead == false || x.IsRead == null);
            ViewBag.UnreadMessageCount = unreadCount;
            return View();
        }
    }
}
