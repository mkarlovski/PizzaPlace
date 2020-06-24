using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.ViewModels
{
    public class OfferViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }



    }
}
