using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DigiMovie.Models;
namespace DigiMovie.ViewModels
{
    public class CustomersFormViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}