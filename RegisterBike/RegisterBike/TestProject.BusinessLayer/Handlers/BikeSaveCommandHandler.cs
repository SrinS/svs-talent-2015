using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BusinessLayer.Contracts;
using TestProject.Common;
using TestProject.DAL.Model;
using TestProject.Repository;

namespace TestProject.BusinessLayer.Handlers
{
    public class BikeSaveCommandHandler : CommandHandlerBase<BikeSaveCommand, CommandResult>
    {
        protected override CommandResult ExecuteCommand(BikeSaveCommand command)
        {
            IBIkeRepository repo = RepositoryManager.CreateRepository<IBIkeRepository>();
            Bike bike = new Bike();
            bike.Boja1 = command.Boja1;
            bike.Boja2 = command.Boja2;
            bike.BrojNaBrizini = command.BrojNaBrizini;
            bike.Flag = command.Flag;
            bike.Grad = command.Grad;
            bike.MaterijalNaRamka = bike.MaterijalNaRamka;
            bike.Model = bike.Model;
            bike.SeriskiBroj = bike.SeriskiBroj;
            bike.Tip = bike.Tip;
            var result = repo.SaveBike(bike);
            //
            return null;
        }
    }
}
