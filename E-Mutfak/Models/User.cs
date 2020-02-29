using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Mutfak.Models
{
    [Table("Users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("TC Kimlik Numarası")]
        public double TCKN { get; set; }

        [DisplayName("Ad Soyad")]
        public string AdSoyad { get; set; }

        [DisplayName("Şifre")]
        public string Sifre { get; set; }

        [DisplayName("Fiyat")]
        public decimal Fiyat { get; set; }

        [DisplayName("Para Birimi")]
        public Doviz paraBirimi { get; set; }
    }
}