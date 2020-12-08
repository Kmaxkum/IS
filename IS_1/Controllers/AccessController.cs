using IS_1.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace IS_1.Controllers
{
    public class AccessController
    {
        private const int MAX_SESSION_LOGIN_ATTEMPTS = 3;
        private DataController dc;
        private UserModel authorizedUser;

        public UserModel AuthorizedUser { get { return authorizedUser; } }

        public AccessController()
        {
            dc = new DataController();
        }

        public int BanCnt()
        {
            return MAX_SESSION_LOGIN_ATTEMPTS;
        }
        
        public Boolean Login(String userName, String password)
        {
            try
            {
                var findUser = dc.UserData.Get(userName);
                if (findUser.AuthCnt >= MAX_SESSION_LOGIN_ATTEMPTS)
                {
                    throw new Exception("Access denied");
                }
                findUser.AuthCnt++;

                password = GetPasswordHash(password);

                if (!findUser.Password.Equals(password))
                {
                    return false;
                }

                authorizedUser = findUser;
                findUser.AuthCnt = 0;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Boolean UserIsExist(String userName)
        {
            return dc.UserData.Exists(userName);
        }

        public UserModel FindUser(String userName)
        {
            if (UserIsExist(userName))
            {
                return dc.UserData.Get(userName);
            }
            throw new Exception("User isn't exist");
        }
        
        public void Register(String userName, String password)
        {
            try
            {
                Register(new UserModel { Login = userName, Password = string.Empty });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Register(UserModel user)
        {
            if (authorizedUser == null)
            {
                throw new Exception("Access denied or user isn't exist");
            }
            if (user.Login.Equals(string.Empty))
            {
                throw new Exception("Non valid data");
            }
            user.Password = string.Empty;
            dc.UserData.Add(user);
        }
        
        public void UpdateAccountAccessRights(String userName, int autrhCnt, bool passwordRestriction)
        {
            try
            {
                UpdateAccountAccessRights(new UserModel { Login = userName }, autrhCnt, passwordRestriction);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void UpdateAccountAccessRights(UserModel user, int autrhCnt, bool passwordRestriction)
        {
            if (authorizedUser == null)
            {
                throw new Exception("Access denied or user isn't exist");
            }
            var updateUser = dc.UserData.Get(user);
            updateUser.AuthCnt = autrhCnt;
            updateUser.PasswordRestriction = passwordRestriction;
        }
        
        public void UpdatePassword(String userName, String newPassword, String oldPassword)
        {
            try
            {
                UpdatePassword(new UserModel { Login = userName }, newPassword, oldPassword);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        
        public void UpdatePassword(UserModel user, String newPassword, String oldPassword)
        {
            newPassword = GetPasswordHash(newPassword);
            var updateUser = dc.UserData.Get(user);

            if (updateUser.Password.Equals(string.Empty) || updateUser.Password == null)
            {
                updateUser.Password = newPassword;
                return;
            }
            else
            {
                if (!updateUser.Password.Equals(GetPasswordHash(oldPassword)))
                {
                    throw new Exception("Invalid old password");
                }
            }
            updateUser.Password = newPassword;
        }
        
        public UserListModel GetUsers()
        {
            if (this.authorizedUser == null)
            {
                throw new Exception("Access denied or user isn't exist");
            }
            return dc.UserData;
        }

        public String GetPasswordHash(String password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                var hash = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                return Convert.ToBase64String(hash);
            }
        }
    }
}
