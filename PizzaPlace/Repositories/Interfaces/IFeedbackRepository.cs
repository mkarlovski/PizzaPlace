using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public interface IFeedbackRepository
    {
        void Add(Feedback feedback);
    }
}
