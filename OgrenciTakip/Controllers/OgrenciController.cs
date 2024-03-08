using Microsoft.AspNetCore.Mvc;
using OgrenciTakip.Models;
using System.Security.Cryptography;

namespace OgrenciTakip.Controllers
{
    public class OgrenciController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        static List<OgrenciModel> ogrenciler = new List<OgrenciModel>();

        [HttpGet]
        public IActionResult Kayit(OgrenciModel ogrenci)
        {
           ogrenciler.Add(ogrenci);
            if (ogrenci.OkulNo < 1)
            {
                return Content("Öğrenci Numarası Geçerli Değil");
            }
            else if (string.IsNullOrEmpty(ogrenci.Isim))
            {
                return Content("Öğrenci Adi Geçerli Değil");
            }
            else if(string.IsNullOrEmpty(ogrenci.SoyIsim))
            {
                return Content("Öğrenci Soyadı Geçerli Değil");
            }
            else if(string.IsNullOrEmpty (ogrenci.Sinifi))
            {
                return Content("Sinifiniz Geçerli Değil");
            }
            else
            {
                return Content("Öğrenci Kayıdı Başarılıdır");
            }
        }
        public IActionResult Listele(OgrenciModel ogrenci)
        {
            return View(ogrenciler);
        }

    }
}
