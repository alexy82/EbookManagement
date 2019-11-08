using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Book
    {
        public int? Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Tên sách")]
        public string Name { get; set; }
        [DisplayName("Nặng(gram)")]
        public int Weight { get; set; }
        [DisplayName("Số trang")]
        public int Pages { get; set; }
        [DisplayName("Đơn giá")]
        public int Price { get; set; }
        [DisplayName("Ngày ra mắt")]
        public DateTime PublicAt { get; set; }
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }
        [DisplayName("Ảnh (url)")]
        public string Picture { get; set; }
        [DisplayName("Kho (url)")]
        public string SaveAt { get; set; }

        [ForeignKey("PublisherId")]
        [DisplayName("Nhà xuất bản")]
        public Publisher Publisher { get; set; }
        public int? PublisherId { get; set; }

        [ForeignKey("LanguageId")]
        [DisplayName("Ngôn ngữ")]
        public Language Language { get; set; }
        public int? LanguageId { get; set; }

        [ForeignKey("SizeId")]
        [DisplayName("Kích thước")]
        public Size Size { get; set; }
        public int? SizeId { get; set; }

        [ForeignKey("AuthorId")]
        [DisplayName("Tác giả")]
        public Author Author { get; set; }
        public int? AuthorId { get; set; }

        public ICollection<Rating> Ratings { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Promotion> Promotions { get; set; }
    }
}
