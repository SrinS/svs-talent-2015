﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Common.Interfaces
{
    public interface IRepositoryFactory
    {
        TRepository CreateRepository<TRepository>() where TRepository:IRepository;
    }
}
