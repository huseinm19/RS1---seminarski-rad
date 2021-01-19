﻿using Data.EFModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS_SEMINARSKI.ModelViews
{
    public class KorisnikEvidentirajVM
    {
        public int KorisnikID { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string AdresaStanovanja { get; set; }
    }
}
