namespace MainApp.Models
{
    public class Loket
    {
        public int Id { get; set; }
        public string NamaLoket { get; set; }
        public ICollection<Petugas> Petugas { get; set;}
        public ICollection<Antrian> Antrians { get; set; }
    }
}
