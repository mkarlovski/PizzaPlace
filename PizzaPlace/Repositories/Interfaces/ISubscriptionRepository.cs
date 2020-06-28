using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface ISubscriptionRepository
    {
        void Add(Subscription subscription);
        Subscription GetByEmail(string email);
    }
}
