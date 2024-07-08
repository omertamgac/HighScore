using HightScore.Entities.Model.Abstract;

namespace HightScore.Entities.Model.Concrete
{
    public class Media : BaseEntity
    {
        public string MediaName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte? MediaLogo { get; set; }
        public string TaxIdNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public string? Fax { get; set; }
    }
}