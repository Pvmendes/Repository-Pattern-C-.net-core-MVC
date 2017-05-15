using Domain.DomainEntities;
using Repository.Configurations.RepositoryConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public interface IRepositoryClient : IRepository
    {
        void Add(Client Entity);
        void Update(Client Entity);
        void UpdateAll(List<Client> Entity);
        void Delete(Client Entity);
        void DeleteById(int id);
        Client GetById(int id);
        IQueryable<Client> GetAll();
    }
}
