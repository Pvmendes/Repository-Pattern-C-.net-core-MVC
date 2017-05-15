using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities.EntityConfig
{
    public abstract class Entity<I> : IEntity<I>
        where I : struct
    {
        public virtual I Id { get; set; }

        public abstract void Validar();
    }
}
