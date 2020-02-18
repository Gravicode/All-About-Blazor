using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoGrpcService.DB
{
    public class ToDoDataContext : DbContext
    {


        public ToDoDataContext(DbContextOptions<ToDoDataContext> options) : base(options)
        {

        }


        public DbSet<ToDoData> ToDoDbItems { get; set; }
    }
}
