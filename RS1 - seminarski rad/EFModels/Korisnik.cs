using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EFModels
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        //public int RolaID { get; set; }
        //public Rola Rola { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string AdresaStanovanja { get; set; }

        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }

        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }


    }
}
