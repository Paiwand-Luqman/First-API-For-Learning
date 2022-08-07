namespace FirstAPI.Models
{
    public class Members
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string phoneNumber { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public decimal ballance { get; set; }
        public byte[] img { get; set; }
    }
}
