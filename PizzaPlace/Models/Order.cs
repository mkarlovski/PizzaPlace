﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public bool IsProcessed { get; set; }
    }
}
