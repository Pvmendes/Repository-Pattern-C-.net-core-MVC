using Domain.DomainEntities.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities
{
    public class Client : Entity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public override void Validar()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name))
            {
                throw new Exception("Name can't be empty");
            }

            if (string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Email))
            {
                throw new Exception("Email can't be empty");
            }
        }
    }
}
