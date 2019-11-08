using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class User
    {
        public int? Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Tên ngươi dùng")]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        [DisplayName("Tên ngươi dùng")]
        public DateTime DOB { get; set; }
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [ForeignKey("RoleId")]
        [DisplayName("Quyền")]
        public Role Role { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn quyền")]
        public int? RoleId { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Rating> Ratings { get; set; }

    }
}
