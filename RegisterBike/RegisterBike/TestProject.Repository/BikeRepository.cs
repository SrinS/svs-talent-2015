using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Common;
using TestProject.DAL.Configuration;

namespace TestProject.Repository
{
    public class BikeRepository : IBIkeRepository
    {
        public bool SaveBike(DAL.Model.Bike bike)
        {
            bool result = false;
            using (var context = new BikeRegisterContext())
            {
                try
                {
                    context.Bikes.Add(bike);
                    context.SaveChanges();
                    result = true;
                }
                catch(Exception err)
                {
                    Logging.LogError("BikeRepository->savebike", err);
                }
               
            }
            return result;
        }
    }
}
