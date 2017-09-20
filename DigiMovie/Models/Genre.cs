using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DigiMovie.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required(ErrorMessage ="لظفا نام دسته بندی را وارد نمایید")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}