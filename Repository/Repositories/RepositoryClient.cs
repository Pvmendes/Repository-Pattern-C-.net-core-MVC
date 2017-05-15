using Domain.DomainEntities;
using Repository.Configurations.RepositoryConfig;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Context;

namespace Repository.Repositories
{
    public class RepositoryClient : Repository<Client, int>, IRepositoryClient
    {
        public RepositoryClient(ApplicationContext contexto) 
            : base(contexto)
        {
        }
    }
}
