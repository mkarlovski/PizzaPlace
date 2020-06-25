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
    public class MenuModel : PageModel
    {
        private readonly IMenuItemService service;

        public MenuModel(IMenuItemService service)
        {
            this.service = service;
        }
        public List<MenuItemModel> MenuItems { get; set; }

        public void OnGet()
        {
            var items = service.GetAll();

            MenuItems = items.Select(x => new MenuItemModel()
            {
             Id=x.Id,
             Title=x.Title,
             Description=x.Description,
             ImageUrl=x.ImageUrl,
             DateCreated=x.DateCreated,
             Price=x.Price
            }).ToList();
        }
    }
}