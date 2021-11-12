using AutoMapper;
using SecurDataAccessLayer.Externals.UserExternals;
using SecurDataAccessLayer.Models;

namespace SecurDataAccessLayer.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ReadUser>().PreserveReferences();
            CreateMap<ReadUser, User>().PreserveReferences();

            CreateMap<User, WriteUser>().PreserveReferences();
            CreateMap<WriteUser, User>().PreserveReferences();

            CreateMap<User, UpdateUser>().PreserveReferences();
            CreateMap<UpdateUser, User>().PreserveReferences();            
        }
    }
}