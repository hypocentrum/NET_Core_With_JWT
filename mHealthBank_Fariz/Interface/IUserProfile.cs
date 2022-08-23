using mHealthBank_Fariz.Entities;

namespace mHealthBank_Fariz.Interface
{
    public interface IUserProfile
    {
        public List<UserProfile> GetList();
        public UserProfile Get(int id);
        public void Add(UserProfile employee);
        public void Update(UserProfile employee);
        public UserProfile Delete(int id);
        public bool Exists(int id);
    }
}
