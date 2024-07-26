using DominLayear.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayear.Context
{
    public class MyAppContext:DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }


        public DbSet<Products> Prodcuts { get; set; }
    }
}
