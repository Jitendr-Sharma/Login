using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMAPP.Models
{
    public class CustDbContext :DbContext
    {  
        public CustDbContext(DbContextOptions<CustDbContext>options):base(options)
        { } 
        public DbSet<Customer> Customer { get; set; } 
        public DbSet<Department> Department { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<VerifyAccount> VerifyAccounts { get; set; }
        
       

    }
}
