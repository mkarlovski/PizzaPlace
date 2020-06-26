﻿using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services.Interfaces
{
    public interface IMenuItemService
    {
        List<MenuItem> GetAll();
        MenuItem GetById(int id);
    }
}
