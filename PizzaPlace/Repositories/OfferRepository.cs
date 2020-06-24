using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public class OfferRepository
    {
        private readonly PizzaPlaceDbContext context;

        public OfferRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }
        public List<Offer> GetAll()
        {
            return context.Offers.ToList();
        }
    }
}
