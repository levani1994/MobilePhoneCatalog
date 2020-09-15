using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilePhoneCatalog.Models
{
    public class MobilePhonesDBContext : DbContext
    {
        public DbSet<PhoneModel> Phones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3PNQ5VO;Initial Catalog=MobilePhoneCatalog;Integrated Security=True");
        }
    }
}
