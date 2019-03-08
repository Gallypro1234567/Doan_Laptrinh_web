using Microsoft.AspNet.Identity.EntityFramework;
using ProJect2.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Data
{
    public class ProJect2DbContext : IdentityDbContext
    {
        public ProJect2DbContext() : base("ProJect2Connection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Nhanvien> Nhanviens { set; get;}
        
        internal void commit()
        {
            throw new NotImplementedException();
        }
        public static ProJect2DbContext Create()
        {
            return new ProJect2DbContext();
        }

    }
}
