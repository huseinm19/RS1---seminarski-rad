using Data.EF;
using Microsoft.AspNetCore.Mvc;
using RS_SEMINARSKI.Helper;
using RS_SEMINARSKI.ModelViews;
using RS1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RS_SEMINARSKI.Controllers
{
    public class AutentifikacijaController : Controller
    {


        public IActionResult Prijava()
        {

            return View("Prijava");
        }
        

        public IActionResult Snimi(AutentifikacijaPrijavaVM m)
        {
            MyDBContext db = new MyDBContext();

            var korisnik = db.Korisnici.Where(a => a.Lozinka == m.Lozinka && a.KorisnickoIme == m.KorisnickoIme).SingleOrDefault(); 

            if(korisnik == null)
            {
                TempData["Poruka"] = "Nisu ispravni podaci za prijavu !"; 
                return Redirect("Prijava");
            }
          
            Get_Set.SetLogiraniKorisnik(HttpContext, korisnik);
            m.KorisnikID = korisnik.KorisnikID;

            KorisnikEvidentirajVM k = new KorisnikEvidentirajVM()
            {
                KorisnickoIme = korisnik.KorisnickoIme,
                Lozinka = korisnik.Lozinka,
                ImeKorisnika = korisnik.ImeKorisnika,
                PrezimeKorisnika = korisnik.PrezimeKorisnika,
                BrojTelefona = korisnik.BrojTelefona,
                AdresaStanovanja = korisnik.AdresaStanovanja,
                Email = korisnik.Email,
                KorisnikID = korisnik.KorisnikID
              
            };


            return Redirect("/Vjencanje/PrikazPocetne?KorisnikID=" + k.KorisnikID);
            //View("~/Views/Vjencanje/PrikazPocetne.cshtml");  jer smo slale model a nismo ga kako terba primile
        }

        public IActionResult Poruka()
        {
            return View("Poruka");
        }

        public IActionResult LogOut()
        {
            Get_Set.SetLogiraniKorisnik(HttpContext, null);
            return Redirect("/"); 
        }
    }
}
