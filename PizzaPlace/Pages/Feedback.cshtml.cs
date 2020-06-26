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
    public class FeedbackModel : PageModel
    {
        private readonly IFeedbackService service;

        public FeedbackModel(IFeedbackService service)
        {
            this.service = service;
        }
        [BindProperty]
        public FeedbackViewModel Feedback { get; set; }

        public void OnGet()
        {
            

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var feedback = new Feedback()
                {
                    Name = Feedback.Name,
                    Message = Feedback.Message,
                    Email = Feedback.Email
                };
                service.Add(feedback);
                
            }
            return RedirectToPage();

        }
    }
}