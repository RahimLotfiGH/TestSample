using System;
using System.Collections.Generic;


namespace InquiryUserAddress.Models
{
     public class Root
    {
        public bool isSuccess { get; set; }
        public List<object> errors { get; set; }
        public List<UserAddressDto> result { get; set; }
    }


}
