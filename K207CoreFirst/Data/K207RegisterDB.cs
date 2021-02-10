using K207CoreFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207CoreFirst.Data
{
    public class K207RegisterDB : DbContext
    {
        #region Dependency Injection
        //Dependency Injection deyilir buna
        public K207RegisterDB(DbContextOptions<K207RegisterDB> options) : base(options)
        {
        }

        #endregion
       public DbSet<Product> Product { get; set; }

       public DbSet<User> Users { get; set; }

    }
}
