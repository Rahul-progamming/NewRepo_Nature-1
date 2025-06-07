using Microsoft.EntityFrameworkCore;
using Nature_WebApplication.Models;
using System;

namespace Nature_WebApplication.Application_Db_Context
{
    public class ApplicationDB : DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {

        }
        public DbSet <SliderImages> images { get; set; }
    }
}
