using Domain.DomainEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context.ConfigMap
{
    public class ClientMap 
    {
        public ClientMap(EntityTypeBuilder<Client> entityBuilder)
        {
        }
    }
}
