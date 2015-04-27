using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Common.Interfaces;
using TestProject.DAL.Model;

namespace TestProject.Repository
{
    public interface IBIkeRepository :IRepository
    {
        bool SaveBike(Bike bike);
    }
}
