using AkademiQPortfolio.Entities;

namespace AkademiQPortfolio.Models
{
    public class DashboardViewModel
    {
        // Sayısal İstatistikler
        public int TotalMessages { get; set; }
        public int UnreadMessages { get; set; }
        public int TotalProjects { get; set; } // Works tablosundan
        public int TotalSkills { get; set; }
        public double AverageSkillValue { get; set; }

        // Grafik Verileri için
        public int JobOfferCount { get; set; }
        public int EduRequestCount { get; set; }
        public int ApiRequestCount { get; set; }
        public int ConsultingRequestCount { get; set; }
        public int FeedbackRequestCount { get; set; }
        public int OtherRequestCount { get; set; }

        // Listeler (Tablolar)
        public List<Work> LastProjects { get; set; } // Son eklenen 3 proje
        public List<Message> LastMessages { get; set; } // Son gelen 5 mesaj
        public List<Skill> TopSkills { get; set; } // En yüksek puanlı 5 yetenek
    }
}
