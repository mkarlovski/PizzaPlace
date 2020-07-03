using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repository;

        public OrderService(IOrderRepository repository )
        {
            this.repository = repository;
        }

        public void Add(Order order)
        {
            repository.Add(order);
        }

        public List<Order> GetAll()
        {
            return repository.GetAll(); 
        }

        public Order GetById(int id)
        {
            return repository.GetById(id);
        }

        

        public List<Order> GetByStatus(bool IsProcessed, bool IsDelivered)
        {
            return repository.GetByStatus(IsProcessed, IsDelivered);
        }

        public void SetDelivered(int id)
        {
            var order = GetById(id);
            if (order != null)
            {
                order.IsDelivered = true;
                repository.Update(order);
            }
        }

        public void SetProcessed(int id)
        {
            var order = GetById(id);
            if (order != null)
            {
                order.IsProcessed = true;
                repository.Update(order);
            }
        }
    }
}
