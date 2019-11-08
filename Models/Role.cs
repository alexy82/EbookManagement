using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Role
    {
        public int? Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Mã quyền")]
        public string Code { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Tên quyền")]
        public string Name { get; set; }
        [DisplayName("Mô tả")]
        public string Desc { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
