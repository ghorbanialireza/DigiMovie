using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigiMovie.Helper.Enums
{
    public enum TypesOfMemberships : byte
    {
        UnKnown, //لطفا انتخاب نمایید
        PayAsYouGo, //رایگان
        Monthly, //ماهانه
        Quarterly, //سه ماهه
        Annual //سالانه
    }
}