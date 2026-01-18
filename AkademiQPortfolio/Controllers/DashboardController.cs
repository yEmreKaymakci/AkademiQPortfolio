using AkademiQPortfolio.Data;
using AkademiQPortfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                //Kart verileri
                TotalMessages = _context.Messages.Count(),
                UnreadMessages = _context.Messages.Count(x => x.IsRead == false),
                TotalProjects = _context.Works.Count(),
                TotalSkills = _context.Skills.Count(),
                AverageSkillValue = _context.Skills.Average(x => (double?)x.SkillValue) ?? 0,
                //Grafik verileri
                JobOfferCount = _context.Messages.Count(x => x.MessageSubject == "Proje Teklifi & İş Birliği"),
                EduRequestCount = _context.Messages.Count(x => x.MessageSubject == "Eğitim & Kurumsal Eğitim Talebi"),
                ApiRequestCount = _context.Messages.Count(x => x.MessageSubject == "Web / API Geliştirme Talebi"),
                ConsultingRequestCount = _context.Messages.Count(x => x.MessageSubject == "Danışmanlık & Teknik Destek"),
                FeedbackRequestCount = _context.Messages.Count(x => x.MessageSubject == "Şikayet & Öneri"),
                OtherRequestCount = _context.Messages.Count(x => x.MessageSubject == "Diğer"),
                //Son 4 projeyi listeleme
                LastProjects = _context.Works.OrderByDescending(x => x.WorkId).Take(4).ToList(),
                //Son 5 mesaj
                LastMessages = _context.Messages.OrderByDescending(x => x.SendDate).Take(5).ToList(),
                //En iyi 5 yetenek
                TopSkills = _context.Skills.OrderByDescending(x => x.SkillValue).Take(5).ToList(),

            };
            return View(model);
        }
    }
}
