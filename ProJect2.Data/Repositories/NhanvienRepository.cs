using ProJect2.Data.Infrastucture;
using ProJect2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Data.Repositories
{
    public interface INhanvienRepository : IRepository<Nhanvien>
    {
        
    }
   public class NhanvienRepository : RepositoryBase<Nhanvien>, INhanvienRepository
    {
        public NhanvienRepository (IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
