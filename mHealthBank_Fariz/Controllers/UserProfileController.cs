using mHealthBank_Fariz.Entities;
using mHealthBank_Fariz.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mHealthBank_Fariz.Controllers
{
    [Authorize]
    [Route("api/user")]
    [ApiController]
    public class UserProfileController : Controller
    {
        private readonly IUserProfile _IUserProfile;

        public UserProfileController(IUserProfile IUserProfile)
        {
            _IUserProfile = IUserProfile;
        }

        // GET: api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProfile>>> Get()
        {
            return await Task.FromResult(_IUserProfile.GetList());
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserProfile>> Get(int id)
        {
            var user = await Task.FromResult(_IUserProfile.Get(id));
            if (user == null)
                return NotFound();
            return user;
        }

        // POST api/user
        [HttpPost]
        public async Task<ActionResult<UserProfile>> Post(UserProfile user)
        {
            _IUserProfile.Add(user);
            return await Task.FromResult(user);
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public async Task<ActionResult<UserProfile>> Put(int id, UserProfile user)
        {
            if (id != user.Id)
                return BadRequest();
            try
            {
                _IUserProfile.Update(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                    return NotFound();
                else
                    throw;
            }
            return await Task.FromResult(user);
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserProfile>> Delete(int id)
        {
            var user = _IUserProfile.Delete(id);
            return await Task.FromResult(user);
        }
        private bool UserExists(int id)
        {
            return _IUserProfile.Exists(id);
        }

    }
}
