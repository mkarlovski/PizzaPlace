using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly PizzaPlaceDbContext context;

        public SubscriptionRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Subscription subscription)
        {
            context.Subscriptions.Add(subscription);
            context.SaveChanges();
        }

        public Subscription GetByEmail(string email)
        {
            return context.Subscriptions.FirstOrDefault(x => x.Email == email);
        }
    }
}
