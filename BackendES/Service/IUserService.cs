using BackendES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendES.Service
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User AddUser(User useritem);      
        public bool DeleteUser(int ID);
        public User UpdateUser(User user);
    }
}
