namespace Bank_WebAPI.Models
{
    public class UserInfo
    {
        public string UserID { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
    }
}
