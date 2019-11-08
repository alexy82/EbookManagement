using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Language
    {
        public int? Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Tên tác giả")]
        public string Name { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Mã vùng")]
        public string Code { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
