using System.Collections.Generic;

namespace Shared.Models
{
    public class GeneralResultModel
    {
        protected GeneralResultModel(string message)
        {
            Message = message;
        }

        private string Message { get; }
        public IDictionary<string, IEnumerable<string>> ModelState { get; set; }

        public bool Error => !string.IsNullOrEmpty(Message);
    }
}