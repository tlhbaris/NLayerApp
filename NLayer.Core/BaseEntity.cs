using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Caching
{
    public abstract class BaseEntity //Soyut sınıflar newlenemez.Genelde abstract classlar projelerde ortak olan property veya methodlarımızı tanımladığımız yerlerdir.
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
