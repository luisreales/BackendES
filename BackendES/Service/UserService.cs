using BackendES.Models;
using BackendES.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendES.Service
{
    public class UserService : IUserService
    {
        

        private IUserRepository userRepository;

        public UserService(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }

        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public User AddUser(User useritem)
        {
            return userRepository.AddUser(useritem);
        }

        public bool DeleteUser(int ID)
        {
            return userRepository.DeleteUser(ID);
        }

        public User UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }

       
    }
}
