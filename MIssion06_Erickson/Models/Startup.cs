using System;
using Microsoft.AspNetCore.Builder;
using MIssion06_Erickson.Models;
using Microsoft.EntityFrameworkCore;

namespace MIssion06_Erickson.Models
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=movies.db"));
            services.AddControllersWithViews();
        }
    }
}
