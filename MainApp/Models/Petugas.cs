namespace MainApp.Models
{
    public class Petugas
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Nik { get; set; }
        public string Alamat { get; set; }
        public string Telepon { get; set; }
        public Gender JenisKelamin { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
    }
}
