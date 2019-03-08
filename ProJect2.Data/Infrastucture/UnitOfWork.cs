using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Data.Infrastucture
{
    class UnitOfWork : IUnitofWork
    {
        private readonly IDbFactory dbFactory;
        private ProJect2DbContext dbContext;
         

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public ProJect2DbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
