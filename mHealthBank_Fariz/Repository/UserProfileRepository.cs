using mHealthBank_Fariz.Interface;
using mHealthBank_Fariz.Entities;

namespace mHealthBank_Fariz.Repository
{
    public class UserProfileRepository : IUserProfile
    {
        readonly MyContext _dbContext;
        public UserProfileRepository(MyContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<UserProfile> GetList()
        {
            try { return _dbContext.UserProfiles.ToList(); }
            catch { throw; }
        }
        public UserProfile Get(int Id)
        {
            try 
            { 
                var model = _dbContext.UserProfiles.Find(Id);
                return model != null ? model : throw new ArgumentNullException();
            }
            catch { throw; }
        }
        public void Add(UserProfile model)
        {
            try
            {
                _dbContext.UserProfiles.Add(model);
                _dbContext.SaveChanges();
            }
            catch { throw; }
        }
        public void Update(UserProfile model)
        {
            try
            {
                _dbContext.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch { throw; }
        }
        public UserProfile Delete(int Id)
        {
            try
            {
                var model = _dbContext.UserProfiles.Find(Id);

                if (model != null)
                {
                    _dbContext.UserProfiles.Remove(model);
                    _dbContext.SaveChanges();
                    return model;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch { throw; }
        }
        public bool Exists(int id)
        {
            return _dbContext.UserProfiles.Any(e => e.Id == id);
        }
    }
}
