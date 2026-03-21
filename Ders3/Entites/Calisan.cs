using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3.Entites
{
    public class Calisan
    {
        public int Id { get; set; }
        public string CalisanAd { get; set; }
        public string CalisanSoyad { get; set; }
        public int DepartmanId { get; set; }
        public Departman Departman{ get; set; }
    }
}
