using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3.Entites
{
    public class Departman
    {
        public int Id { get; set; }
        public string DepartmanAd { get; set; }

        public ICollection<Calisan> Calisanlar { get; set; }
    }
}
