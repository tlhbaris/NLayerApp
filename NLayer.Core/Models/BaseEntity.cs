namespace NLayer.Core.Models
{
    public abstract class BaseEntity //Soyut sınıflar new'lenemez.Genelde abstract classlar projelerde ortak olan property veya methodlarımızı tanımladığımız yerlerdir.
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
