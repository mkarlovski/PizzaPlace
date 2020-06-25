using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class OfferService :IOfferService
    {
        private readonly IOfferRepository repository;

        public OfferService(IOfferRepository repository)
        {
            this.repository = repository;
        }
        public List<Offer> GetAll()
        {
            return repository.GetAll();
        }

        
    }
}
