using Ganss.Excel;

namespace XML_Editor.Models
{
    public class MazeretModel
    {
        [Column("Duruşma Saati")]
        public string DurusmaSaati { get; set; }

        [Column("Duruşma Tarihi")]
        public string DuruşmaTarihi { get; set; }
        [Column("Mazaret  Gönderildiği Tarih")]
        public string MazaretGönderildiğiTarih { get; set; }
        [Column("Duruşma Keşif Sayısı")]
        public int DuruşmaKeşifSayısı { get; set; }
        [Column("Mahkeme İsmi")]
        public string Mahkemeİsmi { get; set; }
        [Column("Esas")]
        public string Esas { get; set; }
        [Column("Duruşma Beyanımız")]
        public string DuruşmaBeyanımız { get; set; }
        [Column("Ara Karar Kurulmasını İstediğimiz Husus")]
        public string AraKararKurulmasınıİstediğimizHusus { get; set; }
    }
}