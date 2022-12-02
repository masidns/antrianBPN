namespace MainApp.Models
{
    public class Layanan
    {
        public int Id { get; set; }
        public string Nama{ get; set; }
        public ICollection<Antrian> Antrians { get; set; }
    }
}
