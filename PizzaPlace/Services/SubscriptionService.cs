using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository repository;

        public SubscriptionService(ISubscriptionRepository repository)
        {
            this.repository = repository;
        }

        public void Add(string email)
        {
            var subscription = new Subscription()
            {
                Email = email,
                DateCreated = DateTime.Now
            };
            repository.Add(subscription);
        }

        public Subscription GetByEmail(string email)
        {
            return repository.GetByEmail(email);
        }
    }
}
