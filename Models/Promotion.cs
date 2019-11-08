using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Promotion
    {
        public int? Id { get; set; }
        [DisplayName("Giảm giá")]
        public int DiscountPrice { get; set; }
        [DisplayName("Giảm phần trăm")]
        public int DiscountPercent { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Ngày hết hạn")]
        public DateTime ExpiredDate { get; set; }

        [ForeignKey("BookId")]
        [DisplayName("Sách")]
        public Book Sách { get; set; }
        public int? BookId { get; set; }
    }
}
