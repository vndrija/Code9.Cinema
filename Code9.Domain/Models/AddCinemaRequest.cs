using System.ComponentModel.DataAnnotations;

namespace Code9.API
{
    public class AddCinemaRequest
    {
        [Required]
        public string Name { get; set; }
        public string City { get; set; }

        public string Street { get; set; }

        public int NumberOfAuditioriums { get; set; }


    }
}
