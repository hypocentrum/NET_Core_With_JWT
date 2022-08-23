namespace mHealthBank_Fariz.Entities
{
    public class UserProfile
    {
        public enum JenisKelaminList { LakiLaki, Perempuan };
        public int Id { get; set; }
        public string? Nama { get; set; }
        public string? Password { get; set; }
        public string? Alamat { get; set; }
        public DateTime TanggalLahir { get; set; }
        public int JenisKelamin { get; set; }
        public string? ImageProfileUrl { get; set; }
    }
}
