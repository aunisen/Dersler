using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Dersler.KutuphaneWpf.Classlar
{
    public class uc_cagir
    {
        public static  void uc_ekle(Grid grid, UserControl uctrl) { grid.Children.Clear(); grid.Children.Add(uctrl);}
    }
}
