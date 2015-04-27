using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    /// <summary>
    /// Data view model show model in View(presentation layer)
    /// </summary>
    public class BikeViewModel
    {
        public BikeViewModel()
        {
        }
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Tip")]
        public string Tip { get; set; }

        [Required]
        [Display(Name = "Seriski broj")]
        public string SeriskiBroj { get; set; }

       // [Required]
       //// [DataType(DataType.Date)]
       // [Display(Name = "Datum na proizvodstvo")]
       // public DateTime DatumNaProizvodstvo { get; set; }

      //  [Required]
      ////  [DataType(DataType.Date)]
      //  [Display(Name = "Datum na kupuvanje")]
      //  public DateTime DatumNaKupuvanje { get; set; }

        [Required]
        [Display(Name = "Grad")]
        public string Grad { get; set; }

        [Required]
        [Display(Name = "Flag")]
        public string Flag { get; set; }

        [Required]
        [Display(Name = "Broj na brzini")]
        public int BrojNaBrizini { get; set; }

        [Required]
        [Display(Name = "Boja1")]
        public string Boja1 { get; set; }

        [Display(Name = "Boja2")]
        public string Boja2 { get; set; }

        [Required]
        [Display(Name = "Materijal na ramka")]
        public string MaterijalNaRamka { get; set; }

        [Required]
        [Display(Name = "Slika")]
        public string Slika { get; set; }



    }
}