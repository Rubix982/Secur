using System;

namespace SecurDataAccessLayer.Externals.UserExternals
{
    public class ReadUser
    {
        public int User_Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Url { get; set; }

        public string State { get; set; }
    }
}