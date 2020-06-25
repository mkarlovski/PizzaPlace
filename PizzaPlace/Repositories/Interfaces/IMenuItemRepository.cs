﻿using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface IMenuItemRepository
    {
        List<MenuItem> GetAll();
    }
}
