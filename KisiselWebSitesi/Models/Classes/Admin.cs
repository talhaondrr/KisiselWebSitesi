using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesi.Models.Classes
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}