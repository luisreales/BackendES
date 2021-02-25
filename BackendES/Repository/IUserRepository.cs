using BackendES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendES.Repository
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User AddUser(User user);        
        public bool DeleteUser(int ID);
        public User UpdateUser(User user);

    }
}
