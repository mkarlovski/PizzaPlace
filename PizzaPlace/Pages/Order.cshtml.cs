using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService service;

        public OrderModel(IOrderService service)
        {
            this.service = service;
        }
        [BindProperty]   //ova go pisuvame za da i kazeme na aplikacijata so koj model da pravi binding
        public OrderViewModel Order { get; set; }
        public void OnGet()
        {


        }

        public void OnPost()   //se izvrsuva sekoga koga se isprakja http request, go koristime so formi da ispratime podatoci
        {

            if (ModelState.IsValid)
            {
                var order = new OrderViewModel()
                {
                    Name = Order.Name,
                    Surname = Order.Surname,
                    Address = Order.Address,
                    Message = Order.Message,
                    Phone = Order.Phone
                };
                service.Add(order);
            }
            
        }

        public void OnPostSubscribe()
        {

        }
    }
}