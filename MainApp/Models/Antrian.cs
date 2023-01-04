using System.ComponentModel.DataAnnotations.Schema;

namespace MainApp.Models
{
    public class Antrian
    {
        public int Id { get; set; }
        public DateTime TanggalAntrian { get; set; } = DateTime.Now;
        public bool Status { get; set; }
        public Client Client { get; set; }
        public Layanan Layanan { get; set; }
        public Petugas? Petugas { get; set; }
        
        //[NotMapped]
        public int Nomor { get; set; }
    }
}
