namespace InquiryUserAddress.Models
{
    public class UserAddressDto
    {
        public long Id { get; set; }

        public string Address { get; set; }

        public int CityId { get; set; }

        public long AppUserId { get; set; }


    }
}
