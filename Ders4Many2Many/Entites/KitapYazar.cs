using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Many2Many.Entites
{
    public class KitapYazar
    {
        public int KitapId { get; set; }
        public int YazarId { get; set; }
            public Kitap Kitap { get; set; }    
            public Yazar Yazar { get; set; }
    }
}
