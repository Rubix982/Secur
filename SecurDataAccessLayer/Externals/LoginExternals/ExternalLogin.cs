using System;
using System.Collections.Generic;

namespace SecurDataAccessLayer.Externals.LoginExternals
{
    public class ExternalLogin
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public string State { get; set; }
    }
}