using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Many2Many.Entites
{
    public class Kitap

    {
        public int Id { get; set; }
        public string Ad { get; set; } 
        public ICollection<KitapYazar> KitapYazarlar { get; set; }
    }
}
