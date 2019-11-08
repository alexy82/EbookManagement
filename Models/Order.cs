using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Order
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
        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("CustomerId")]
        [DisplayName("Khách hàng")]
        public User Customer { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn quyền")]
        public int? CustomerId { get; set; }


        public Transaction Transaction { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
