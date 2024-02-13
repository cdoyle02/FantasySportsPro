using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Domain.Models
{
    public class SportAssociationLookUp
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public SportAssociationLookUp(int id, string abbreviation, string name)
        {
            Id = id;
            Abbreviation = abbreviation;
            Name = name;
        }
    }
}
