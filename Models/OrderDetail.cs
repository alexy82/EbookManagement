using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class OrderDetail
    {
        public int? Id { get; set; }
        [DisplayName("Số lương")]
        public int Quantity { get; set; }
        [DisplayName("Đơn giá")]
        public string Price { get; set; }

        [ForeignKey("BookId")]
        [DisplayName("Sách")]
        public Book Book { get; set; }
        public int? BookId { get; set; }

        [ForeignKey("OrderId")]
        [DisplayName("Đơn hàng")]
        public Order Order { get; set; }
        public int? OrderId { get; set; }


    }
}
