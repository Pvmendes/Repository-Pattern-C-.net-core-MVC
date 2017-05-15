using Domain.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{
    public interface IServiceClient
    {
        void Add(Client Entity);
        void Update(Client Entity);
        void UpdateAll(List<Client> Entity);
        void Delete(Client Entity);
        void DeleteById(int id);
        Client GetById(int id);
        IQueryable<Client> GetAll();
        string[] GetAllOnArrayString();
    }
}
