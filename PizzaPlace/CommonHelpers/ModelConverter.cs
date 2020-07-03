using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.CommonHelpers
{
    public static class ModelConverter
    {
        public static OrderViewModel ConvertToOrderViewModel(Order order)
        {
            return new OrderViewModel()
            {
                Id = order.Id,
                Name = order.Name,
                Surname = order.Surname,
                Message = order.Message,
                Address = order.Address,
                Phone = order.Phone,
                IsProcessed = order.IsProcessed,
                IsDelivered = order.IsDelivered
            };
        }
    }
}
