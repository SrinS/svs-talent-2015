using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Model;

namespace TestProject.BusinessLayer.Contracts
{
    public class BikeSearchResult:CommandResult
    {
        public List<Bike> Result { get; set; }
    }
}
