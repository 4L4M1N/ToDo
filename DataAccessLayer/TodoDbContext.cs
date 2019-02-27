using System;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.DataAccessLayer
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
            
        }
        public DbSet<Work> Works {get; set;}
    }
}