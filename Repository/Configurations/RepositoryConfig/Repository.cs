using Microsoft.EntityFrameworkCore;
using Domain.DomainEntities.EntityConfig;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Configurations.RepositoryConfig
{
    public abstract class Repository<E, I> : IRepository
        where E : class, IEntity<I>, new()
        where I : struct
    {
        public Repository(ApplicationContext contexto)
        {
            this.Context = contexto;
        }

        protected ApplicationContext Context { get; set; }

        public virtual void Add(E Entity)
        {
            this.Context.Set<E>().Add(Entity);
            this.Context.SaveChanges();
        }
        
        public virtual void Update(E Entity)
        {
            var e = this.Context.Entry(Entity);
            e.State = EntityState.Modified;
            this.Context.SaveChanges();
        }

        public virtual void UpdateAll(List<E> Entity)
        {
            Entity.ForEach(x =>
            {
                this.Update(x);
            });
        }

        public virtual void Delete(E Entity)
        {
            this.Context.Set<E>().Remove(Entity);
            this.Context.SaveChanges();
        }

        public virtual void DeleteById(int id)
        {
            E Entity = GetById(id);
            this.Delete(Entity);
        }

        public virtual E GetById(int id)
        {
            return this.Context.Set<E>().Find(id);
        }

        public virtual IQueryable<E> GetAll()
        {
            return this.Context.Set<E>();
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }        
    }
}
