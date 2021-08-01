using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Domain.Model
{
    public class Sponsors
    {
        public int Id { get; set; }

        public string SponsorsName { get; set; }

        public int SposnorsTypeId { get; set; }

        public SposnorsType SposnorsType { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}
