using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace cengPC
{
    public class Uyeler
    {
        public Guid UyeId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Sifre { get; set; }
    }
}
