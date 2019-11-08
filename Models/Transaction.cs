using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Transaction
    {
        public int? Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Mã thanh toán")]
        public string Code { get; set; }
        [DisplayName("Tổng tiền")]
        public double Total { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("OrderId")]
        [DisplayName("Đơn hàng")]
        public Order Order { get; set; }
        public int? OrderId { get; set; }
    }
}
