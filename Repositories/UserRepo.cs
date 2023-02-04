using WebSec3_IPN.Data;
using WebSec3_IPN.Models;
using WebSec3_IPN.ViewModels;

namespace WebSec3_IPN.Repositories
{
    public class UserRepo
    {
        ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<UserVM> GetUsers()
        {
            IEnumerable<UserVM> users =
    _context.Users.Select(u => new UserVM() { Email = u.Email });

            return users.ToList();
        }
        public MyRegisteredUser GetUser(string username)
        {
            var user =
    _context.MyRegisteredUsers.Select(u => u).Where(u=>u.Email==username).FirstOrDefault();

            return user;
        }

    }
}
