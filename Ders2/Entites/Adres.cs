using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2.Entites
{
    public class Adres
    {
        public int Id { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Sokak { get; set; }

        public Ogrenci Ogrenci { get; set; }
    }
}
