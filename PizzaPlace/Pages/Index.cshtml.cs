using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {

        }
        public List<OfferViewModel> Offers { get; set; }
        public void OnGet()
        {
            Offers = new List<OfferViewModel>();
            var offer = new OfferViewModel()   //so ova pravime mapiranje na objektot od baza so toa sto ke koristi stranata
            {
                Title = "Perfect Combo",
                Description = "Test description about the offer",
                DateCreated = DateTime.Now
            };
            Offers.Add(offer);
        }
    }
}
