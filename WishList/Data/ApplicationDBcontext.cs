using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDBcontext : DbContext
    {
		public	DbSet<Item> Items { get; set; }
		public	ApplicationDBcontext(DbContextOptions options) : base(options)
        {


        }
    }
}
