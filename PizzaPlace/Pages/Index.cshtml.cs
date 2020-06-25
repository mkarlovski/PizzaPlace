using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IOfferService service;

        public IndexModel(IOfferService service)
        {
            this.service = service;
        }
        public List<OfferViewModel> Offers { get; set; }
        public void OnGet()
        {
            var dbOffers = service.GetAll();

            Offers = dbOffers.Select(x => new OfferViewModel()   //so ova pravime mapiranje na objektot od baza so toa sto ke koristi stranata
            {
                Title = x.Title,
                Description = x.Description,
                DateCreated = x.DateCreated,
                Price=x.Price
            }).ToList();
        }
    }
}
