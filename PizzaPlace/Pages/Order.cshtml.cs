using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService service;
        private readonly ISubscriptionService subscriptionService;

        public OrderModel(IOrderService service, ISubscriptionService subscriptionService)
        {
            this.service = service;
            this.subscriptionService = subscriptionService;
        }
        [BindProperty]   //ova go pisuvame za da i kazeme na aplikacijata so koj model da pravi binding
        public OrderViewModel Order { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {


        }

        public IActionResult OnPost()   //se izvrsuva sekoga koga se isprakja http request, go koristime so formi da ispratime podatoci
        {

            if (ModelState.IsValid)
            {
                var order = new Order()
                {
                    Name = Order.Name,
                    Surname = Order.Surname,
                    Address = Order.Address,
                    Message = Order.Message,
                    Phone = Order.Phone
                };
                service.Add(order);
                return RedirectToPage("Confirmation", "Order");
            }
            return Page();
            
        }

        public IActionResult OnPostSubscribe(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                var currentEmail = subscriptionService.GetByEmail(email);

                if (currentEmail == null)
                {
                    subscriptionService.Add(email);

                    return RedirectToPage("Confirmation", "Subscribe");
                }
                ErrorMessage = "User already exists";
                return Page();
            }

            ErrorMessage = "Please enter email";

            return Page();
        }
    }
}