using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class PizzaPlaceDbContext :DbContext
    {
        public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options) : base(options)
        {

        }
        public DbSet<Offer> Offers { get; set; }    //so ova kazuvame kako ke se vika tabelata vo baza i koj model ke go koristi
    }
}
