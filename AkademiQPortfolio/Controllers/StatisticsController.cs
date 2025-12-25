using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;

        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult StatisticsCards()
        {
            var messageCount = _context.Messages.Count();
            var messageCountByIsReadTrue = _context.Messages.Where(m => m.IsRead == true).Count();
            var messageCountByIsReadFalse = _context.Messages.Where(m => m.IsRead == false).Count();
            var skillCount = _context.Skills.Count();
            var skillAvgValue = _context.Skills.Average(s => s.SkillValue);
            var skillValueBiggerThan70 = _context.Skills.Where(s => s.SkillValue >= 70).Count();

            ViewBag.MessageCount = messageCount;
            ViewBag.MessageCountByIsReadTrue = messageCountByIsReadTrue;
            ViewBag.MessageCountByIsReadFalse = messageCountByIsReadFalse;
            ViewBag.SkillCount = skillCount;
            ViewBag.SkillAvgValue = skillAvgValue;
            ViewBag.SkillValueBiggerThan70 = skillValueBiggerThan70;

            var messageSubjectsByWorkOffer = _context.Messages.Where(x => x.MessageSubject == "Proje Teklifi & İş Birliği").Count();
            var messageSubjectsByApiDevelopment = _context.Messages.Where(x => x.MessageSubject == "Web / API Geliştirme Talebi").Count();
            var messageSubjectsByEducationOffer = _context.Messages.Where(x => x.MessageSubject == "Eğitim & Kurumsal Eğitim Talebi").Count();
            //var messageSubjectsByWorkOffer = _context.Messages.Where(x => x.MessageSubject == "Proje Teklifi & İş Birliği").Count();

            ViewBag.MessageSubjectsByWorkOffer = messageSubjectsByWorkOffer;
            ViewBag.MessageSubjectsByApiDevelopment = messageSubjectsByApiDevelopment;
            ViewBag.MessageSubjectsByEducationOffer = messageSubjectsByEducationOffer;

            return View();
        }
    }
}
