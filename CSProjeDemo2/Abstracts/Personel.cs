using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Abstracts
{
    public abstract class Personel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public abstract decimal MaasHesapla();
    }
}
