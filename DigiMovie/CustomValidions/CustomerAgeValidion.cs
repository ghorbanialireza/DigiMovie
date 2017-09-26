using DigiMovie.Helper.Enums;
using DigiMovie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigiMovie.CustomValidions
{
    public class CustomerAgeValidion : ValidionAttribute
    {
        protected override ValidationResult Isvalid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId== (byte)TypesOfMemberships.UnKnown || customer.MembershipTypeId == (byte)TypesOfMemberships.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.BirthDate == null)
                return new ValidationResult("لطفا تاریخ تولد خود را وارد نمایید");
            var age = DateTime.Now.Year - customer.BirthDate.Value.Year;
            if(age>=18)
                return ValidationResult.Success;
            else
                return new ValidationResult("برای نوع عضویت های غیر رایگان، حداقل 18 سال سن الزامی می باشد");
        }
    }
}