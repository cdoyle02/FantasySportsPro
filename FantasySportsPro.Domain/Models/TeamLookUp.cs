using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Domain.Models
{
    public class TeamLookUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int SportAssociationId { get; set; }

        public TeamLookUp(int id, string name, string city, string state, string country, int sportAssociationId)
        {
            Id = id;
            Name = name;
            City = city;
            State = state;
            Country = country;
            SportAssociationId = sportAssociationId;
        }
    }
}
