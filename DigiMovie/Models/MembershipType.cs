using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DigiMovie.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required(ErrorMessage = "لطفا نوع عضویت را وارد نمایید")]
        [StringLength(50)]
        public string Name { get; set; }

        public byte DurationInMonth { get; set; }

        public short SignUpFee { get; set; }

        public byte DiscountRate { get; set; }

    }
}