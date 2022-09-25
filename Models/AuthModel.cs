namespace WebApplication1.Models
{
    public class AuthModel
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }

        public string Username { get; set; }
        
        public string Email { get; set; }

        public List<String> Roles { get; set; }
        public string Token { get; set; }
        public DateTime Expiration  { get; set; }



    }
}
