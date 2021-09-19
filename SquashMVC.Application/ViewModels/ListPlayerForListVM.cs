using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Application.ViewModels
{
    public class ListPlayerForListVM
    {
        public List<PlayerForListVM> Players { get; set; }

        public int count { get; set; }
    }
}
