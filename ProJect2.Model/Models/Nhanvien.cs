using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Model.Models
{
    [Table("Nhanvien")]
    public class Nhanvien
    {
        public int ID { set; get; }

        public string NV_HO { set; get; }

        public string NV_TEN { set; get; }

        public string NV_GIOITINH { set; get; }

        public DateTime NV_NGAYSINH { set; get; }

        public string NV_NOISINH { set; get; }

        public string SDT { set; get; }

    }
}
