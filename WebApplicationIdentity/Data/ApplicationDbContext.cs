using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationIdentity.Models;

namespace WebApplicationIdentity.Data
{
    public class MyNewDbContext : IdentityDbContext<User>
    {
        public MyNewDbContext(DbContextOptions<MyNewDbContext> options)
            : base(options)
        {
        }
    }
}
