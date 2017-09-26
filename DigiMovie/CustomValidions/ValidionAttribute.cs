using System;
using System.ComponentModel.DataAnnotations;

namespace DigiMovie.CustomValidions
{
    public class ValidionAttribute
    {
        internal ValidationResult Isvalid(object value, ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}