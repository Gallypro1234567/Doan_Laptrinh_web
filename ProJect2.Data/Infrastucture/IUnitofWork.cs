using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Data.Infrastucture
{
    public interface IUnitofWork
    {
        void Commit();
    }
}
