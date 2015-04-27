using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Common.Interfaces;
using TestProject.Repository;

namespace Registar.Repository
{
    /// <summary>
    /// Responsible for creating of repositories
    /// </summary>
    public class DefaultRepositoryFactory : IRepositoryFactory
    {

        public TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {
            if (typeof(TRepository) == typeof(IBIkeRepository))
            {
                return (TRepository)(object)new BikeRepository();
            }

            return default(TRepository);
        }
    }
}
