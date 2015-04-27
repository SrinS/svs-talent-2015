using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.DAL.Model
{
    public class Bike
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public string Tip { get; set; }

        public string SeriskiBroj { get; set; }

        public string Grad { get; set; }

        public string Flag { get; set; }

        public int BrojNaBrizini { get; set; }

        public string Boja1 { get; set; }

        public string Boja2 { get; set; }

        public string MaterijalNaRamka { get; set; }

    }
}
