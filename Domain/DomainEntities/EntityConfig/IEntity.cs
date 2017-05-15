using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities.EntityConfig
{
    public interface IEntity<I>
        where I : struct
    {
        I Id { get; set; }
        void Validar();
    }
}
