using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Domain.Model
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Rank { get; set; }

        public bool IsActive { get; set; }

       

        public int SexId { get; set; }
        public virtual Sex Sex { get; set; }

        public int AssociationId { get; set; }
        public virtual Association Association { get; set; }

        public int CountryId { get; set; } 
        public virtual Country Country { get; set; }

        // public int SponsorId { get; set; }
        public virtual ICollection<Sponsors> Sponsors { get; set; }
    }
}
