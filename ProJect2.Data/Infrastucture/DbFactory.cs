using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Data.Infrastucture
{
    public class DbFactory : Disposable, IDbFactory
    {
        public ProJect2DbContext DbContext;
        public ProJect2DbContext Init()
        {
            return DbContext ?? (DbContext = new ProJect2DbContext());
        }
        protected override void DisposeCore()
        {
            if (DbContext != null)
                DbContext.Dispose();
        }
    }
}
