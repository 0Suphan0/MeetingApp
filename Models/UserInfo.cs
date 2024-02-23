using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Alanı Zorunludur.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Alanı Zorunludur.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email Zorunludur.")]
        [EmailAddress(ErrorMessage ="Hatalı email formatı.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım durumu belirtilmelidir.")]
        public bool?  WillAttend { get; set; }


    }
}
