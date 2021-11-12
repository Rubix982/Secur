namespace SecurDataAccessLayer.Externals.UserExternals
{
    public abstract class ReadUser
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Url { get; set; }

        public string State { get; set; }
    }
}