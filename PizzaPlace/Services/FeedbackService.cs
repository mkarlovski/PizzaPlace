using PizzaPlace.Models;
using PizzaPlace.Repositories;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository repository;

        public FeedbackService(IFeedbackRepository repository)
        {
            this.repository = repository;
        }

        public void Add(Feedback feedback)
        {
            repository.Add(feedback);
        }
    }
}
