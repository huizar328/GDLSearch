using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTopicPlaces.Controllers.Entities;

namespace WebApiTopicPlaces.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {


        }
        public DbSet<Topic> Topics { get; set; }
    }
}
