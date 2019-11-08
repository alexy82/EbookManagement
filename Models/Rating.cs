using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Rating
    {

        public int? Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Nội dung")]
        public string Content { get; set; }

        [DisplayName("Tạo lúc")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Số sao")]
        public DateTime Star { get; set; }

        [ForeignKey("RatedById")]
        [DisplayName("Người đánh giá")]
        public User RatedBy  { get; set; }
        public int? RatedById { get; set; }

        [ForeignKey("BookId")]
        [DisplayName("Sách")]
        public Book Book { get; set; }
        public int? BookId { get; set; }
    }
}
