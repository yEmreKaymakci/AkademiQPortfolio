using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AkademiQPortfolio.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Mesajları tarihe göre yeniden eskiye sıralayarak getir
            var values = _context.Messages.OrderByDescending(x => x.SendDate).ToList();
            return View(values);
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public JsonResult ChangeStatus(int id)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine($"[LOG] ChangeStatus çağrıldı! ID: {id}");

                // 1. Önce mevcut değeri oku
                var message = _context.Messages.FirstOrDefault(x => x.MessageId == id);

                if (message == null)
                {
                    return Json(new { success = false, message = "Mesaj bulunamadı" });
                }

                // 2. Yeni değeri hesapla
                bool newValue = !(message.IsRead ?? false);

                System.Diagnostics.Debug.WriteLine($"[LOG] Eski: {message.IsRead}, Yeni: {newValue}");

                // 3. SQL ile direkt güncelle
                int rowsAffected = _context.Database.ExecuteSqlRaw(
                    "UPDATE Messages SET IsRead = {0} WHERE MessageId = {1}",
                    newValue, id
                );

                System.Diagnostics.Debug.WriteLine($"[LOG] Güncellenen satır sayısı: {rowsAffected}");

                if (rowsAffected == 0)
                {
                    return Json(new { success = false, message = "Güncelleme başarısız!" });
                }

                return Json(new { success = true, isRead = newValue });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[HATA] {ex.Message}");
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
