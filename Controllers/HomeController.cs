using kıvıl.Context;
using kıvıl.Entities;
using kıvıl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace kıvıl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using AppDbContext appDbContext = new AppDbContext();

            var data = appDbContext.Hastalar.Include(h => h.Test)
                .ToList();


            return View(data);
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Hasta hasta)
        {
            using AppDbContext appDbContext = new AppDbContext();

            var data = new Hasta()
            {
                Isim = hasta.Isim,
                Soyisim = hasta.Soyisim,
                AileGecmisi = hasta.AileGecmisi,
                AlkolKullanımı = hasta.AlkolKullanımı,
                Cinsiyet = hasta.Cinsiyet,
                EgzersizYapıyorMu = hasta.EgzersizYapıyorMu,
                Yas = hasta.Yas,
                KalpKriziRiski = hasta.KalpKriziRiski,
                HastaId = hasta.HastaId,
                SigaraKullanımı = hasta.SigaraKullanımı,
                Test = hasta.Test,
            };

            appDbContext.Hastalar.Add(data);
            appDbContext.SaveChanges();

            return RedirectToAction("Index","Home");
        }


        [HttpGet]
        public IActionResult AddTest()
        {

          
            return View();
        }

        [HttpPost]
        public IActionResult AddTest(Test test)
        {
            using AppDbContext appDbContext = new AppDbContext();

            var data = new Test()
            {
                KanBasıcı=test.KanBasıcı,
                Kolestrol=test.Kolestrol,
                KanSekeri=test.KanSekeri,
                HastaId=test.HastaId,
                Hasta=test.Hasta,
                
            };

            appDbContext.Testler.Add(data);
            appDbContext.SaveChanges();


            return RedirectToAction("Index","Home");
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
