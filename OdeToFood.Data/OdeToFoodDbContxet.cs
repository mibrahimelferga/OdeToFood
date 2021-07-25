using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContxet : DbContext
    {
        public OdeToFoodDbContxet(DbContextOptions<OdeToFoodDbContxet> options)
            : base(options)
        {
                
        }
        public DbSet<Resturant> Resturants { get; set; }
    }
}
