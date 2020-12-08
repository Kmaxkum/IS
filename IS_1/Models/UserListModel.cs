using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_1.Models
{
    public class UserListModel
    {
        public List<UserModel> Users { get; set; }

        public UserListModel()
        {
            Users = new List<UserModel>();
        }

        public bool Exists(string login)
        {
            return Exists(new UserModel() { Login = login });
        }

        public bool Exists(UserModel user)
        {
            if (!Users.Exists(u => u.Login.Equals(user.Login)))
            {
                return false;
            }

            return true;
        }

        // Exception
        public UserModel Get(string login)
        {
            try
            {
                return Find(new UserModel() { Login = login });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Exception
        public UserModel Get(UserModel user)
        {
            if (!Exists(user))
            {
                throw new Exception("User isn't exist");
            }

            return Find(user);
        }

        // Exception
        public void Add(UserModel user)
        {
            if (Exists(user))
            {
                throw new Exception("User is exist");
            }

            Users.Add(user);
        }

        private UserModel Find(UserModel user)
        {
            return Users.Find(u => u.Login.Equals(user.Login));
        }
    }
}
