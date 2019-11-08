﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBOOK_WED_APP.Models
{
    public class Size
    {
        public int? Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayName("Giá trị")]
        public string Value { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DisplayName("Mã vùng")]
        public string Code { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
