using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DigiMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? BirthDate { get; set; }


        #region
        //This is forign key
        public byte MembershipTypeId { get; set; }
        //This is navigation property
        public MembershipType MembershipType { get; set; }
        #endregion
    }
}