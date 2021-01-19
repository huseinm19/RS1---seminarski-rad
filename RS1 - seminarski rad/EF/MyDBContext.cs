using Data.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace Data.EF
{
    public class MyDBContext:DbContext
    {

        public DbSet<Korisnik> Korisnici { get; set; }




        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString:
        //                                  @"Server=app.fit.ba,1431;
        //                                  Database=fitba2048;
        //                                  Trusted_Connection=false;
        //                                  User ID=p2048;
        //                                  Password=s6RUcy3!;
        //                                  MultipleActiveResultSets=true");

        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( @"Server=.;
                                          Database=fitba2063;
                                          Trusted_Connection=true;
                                          MultipleActiveResultSets=true");

        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<MuzikaBend>()
        //    //   .HasKey(pp => new { pp.MuzikaID, pp.BendID });

        //    //modelBuilder.Entity<KuharMeni>()
        //    //    .HasKey(pp => new { pp.MeniID, pp.KuharID });

        //    //modelBuilder.Entity<RezervacijaCvijece>()
        //    //    .HasKey(pp => new { pp.CvijeceID, pp.RezervacijaID });

        //    //modelBuilder.Entity<RezervacijaDekoracija>()
        //    // .HasKey(pi => new { pi.RezervacijaID, pi.DekoracijaID });

        //    //modelBuilder.Entity<RezervacijaFotograf>()
        //    // .HasKey(up => new { up.RezervacijaID, up.FotografID });

        //    //modelBuilder.Entity<RezervacijaKorisnik>()
        //    // .HasKey(uu => new { uu.KorisnikID, uu.RezervacijaID });

        //    //modelBuilder.Entity<RezervacijaSala>()
        //    // .HasKey(bl => new { bl.RezervacijaID, bl.SalaID });

        //   // modelBuilder.Entity<SalaKonobar>()
        //   //.HasKey(bl => new { bl.SalaID, bl.KonobarID });


        //}



    }
}
