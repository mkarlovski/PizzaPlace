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
    public class DetailsModel : PageModel
    {
        private readonly IMenuItemService menuItemService;

        public DetailsModel(IMenuItemService menuItemService)
        {
            this.menuItemService = menuItemService;
        }
        public MenuItemModel MenuItem { get; set; }

        public void OnGet(int id)
        {
            var item = menuItemService.GetById(id);

            MenuItem = new MenuItemModel()
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                DateCreated = item.DateCreated,
                Price = item.Price,
                ImageUrl = item.ImageUrl
            };
        }
    }
}