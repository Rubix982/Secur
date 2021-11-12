namespace Shared.Models
{
    public class LoginResultModel
    {
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
        public string AccessToken { get; set; }
        public TokenType TokenType { get; set; } 
        public long ExpiresIn { get; set; }
    }

    public enum TokenType
    {
        Bearer
    }
}