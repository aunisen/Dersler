using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2.Entites
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int  Numara{ get; set; }  
        public Adres Adres { get; set; }
    }
}
