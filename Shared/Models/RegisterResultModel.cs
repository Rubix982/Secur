namespace Shared.Models
{
    public class RegisterResultModel : GeneralResultModel
    {
        public string MembershipNumber { get; set; }

        public RegisterResultModel(string message) : base(message)
        {
        }
    }
}