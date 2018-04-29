using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonApplication.ViewModel
{
    public class PersonAddressViewModel
    {
        public int PersonId { get; set; }
        //[Required(ErrorMessage = "Name is Required")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "Name is Required")]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "Email is Required")]
        //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        //                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        //                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
        //                    ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Address is Required")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        //[Required(ErrorMessage = "City is Required")]
        public string City { get; set; }
        //[Required(ErrorMessage = "State is Required")]
        public string State { get; set; }
        //[Required(ErrorMessage = "Zipcode is Required")]
        public string ZipCode { get; set; }

    }
}