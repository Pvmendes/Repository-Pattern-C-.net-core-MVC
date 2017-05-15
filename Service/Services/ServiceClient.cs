using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.DomainEntities;
using System.Linq;

namespace Service.Services
{
    public class ServiceClient : IServiceClient
    {
        private IRepositoryClient repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }

        public void Add(Client Entity)
        {
            this.repositoryClient.Add(Entity);
        }

        public Client GetById(int id)
        {
            return this.repositoryClient.GetById(id);
        }

        public void Update(Client Entity)
        {
            this.repositoryClient.Update(Entity);
        }

        public void UpdateAll(List<Client> Entity)
        {
            this.repositoryClient.UpdateAll(Entity);
        }

        public void Delete(Client Entity)
        {
            this.repositoryClient.Delete(Entity);
        }

        public void DeleteById(int id)
        {
            this.repositoryClient.DeleteById(id);
        }

        public IQueryable<Client> GetAll()
        {
            return this.repositoryClient.GetAll();
        }

        public string[] GetAllOnArrayString()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
