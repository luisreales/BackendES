using BackendES.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendES.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly UserDbContext _context;       
        private readonly DbSet<User> _users;


        public UserRepository(UserDbContext context)
        {
            _context = context;
            _users = _context.Users;
        }

        public List<User> GetUsers()
        {
            return _users.ToList();
        }

        public User AddUser(User user)
        {
            this._users.Add(user);
            this._context.SaveChanges();
            return user;
        }

        public User UpdateUser(User user)
        {
            this._users.Update(user);
            this._context.SaveChanges();
            return user;
        }

        public bool DeleteUser(int ID)
        {
            var userItem = _context.Users.Find(ID);
            if (userItem != null)
            {
                _context.Users.Remove(userItem);
                
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
