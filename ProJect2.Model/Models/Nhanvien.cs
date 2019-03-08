using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect2.Model.Models
{
    [Table("Nhanvien")]
    public class Nhanvien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(200)]
        public string NV_HO { set; get; }

        [Required]
        [MaxLength(100)]
        public string NV_TEN { set; get; }

        [MaxLength(100)]
        public string NV_GIOITINH { set; get; }

        public DateTime NV_NGAYSINH { set; get; }

        [MaxLength(500)]
        public string NV_NOISINH { set; get; }

        [MaxLength(100)]
        public string SDT { set; get; }

        [MaxLength(100)]
        public string CMNN { set; get; }
    }
}
