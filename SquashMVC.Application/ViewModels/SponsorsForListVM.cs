using SquashMVC.Domain.Model;

namespace SquashMVC.Application.ViewModels
{
    public class SponsorsForListVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SposnorsType Type { get; set; }
    }
}