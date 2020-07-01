using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOrderService
    {
        void Add(Order order);
        List<Order> GetAll();
        Order GetById(int id);
        void SetProcessed(int id);
    }
}
