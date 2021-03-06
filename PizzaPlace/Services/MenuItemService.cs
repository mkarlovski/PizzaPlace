﻿using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository repository;

        public MenuItemService(IMenuItemRepository repository)
        {
            this.repository = repository;
        }
        public List<MenuItem> GetAll()
        {
            return repository.GetAll();
        }

        public MenuItem GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
