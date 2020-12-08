using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json;

using IS_1.Models;

namespace IS_1.Controllers
{
    public class DataController
    {
        private DES Des;

        // Добавление к основному ключу еще одной части
        private String FirstKey = "4321";
        private String SecondKey = "1234";

        private String FilePath = "";
        private String RootPath = "";

        private UserListModel UserList = new UserListModel();

        public UserListModel UserData { get { return UserList; } }
        public String DefaultAdminLogin { get { return "ADMIN"; } }

        public DataController()
        {
            Des = DES.Create();
            Des.Mode = CipherMode.CFB;
            var bytes = Encoding.ASCII.GetBytes(FirstKey + SecondKey);
            Des.Key = bytes;
            Des.IV = bytes;

            RootPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            FilePath = Path.Combine(new String[] {
                RootPath,
                "IS_1",
                "Data",
                "user.json"
            });

            var admin = new UserModel()
            {
                Login = "ADMIN",
                Password = String.Empty,
                AuthCnt = 0,
                Rule = true,
                PasswordRestriction = false
            };

            if (!CreateDataFile())
            {
                try
                {
                    UserList.Add(admin);
                    var add = UserList.Get(admin);
                    BaseDESEncode();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    System.Environment.Exit(0);
                }
            }
            else
            {
                try
                {
                    BaseDESDecode();
                    var add = UserList.Get(admin);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    System.Environment.Exit(0);
                }
            }
        }

        private Boolean CreateDataFile()
        {
            if (!File.Exists(FilePath))
            {
                try
                {
                    FileStream accessFile = File.Create(FilePath);
                    accessFile.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                return false;
            }

            return true;
        }
        
        private void BaseDESDecode()
        {
            if (!File.Exists(FilePath))
            {
                throw new Exception("File isn't exist.");
            }
            
            FileStream fileStream = File.Open(FilePath, FileMode.Open);

            CryptoStream cryptoStream = new CryptoStream(
               fileStream,
               Des.CreateDecryptor(Des.Key, Des.IV),
               CryptoStreamMode.Read
            );

            StreamReader streamReader = new StreamReader(cryptoStream);
            String input = streamReader.ReadLine();

            streamReader.Close();
            cryptoStream.Close();
            fileStream.Close();

            UserList = JsonConvert.DeserializeObject<UserListModel>(input);
        }
        
        private void BaseDESEncode()
        {
            String output = JsonConvert.SerializeObject(UserList);
            
            FileStream fileStream = File.Open(FilePath, FileMode.Open);
            CryptoStream cryptoStream = new CryptoStream(
                fileStream,
                Des.CreateEncryptor(Des.Key, Des.IV),
                CryptoStreamMode.Write
            );

            StreamWriter streamWriter = new StreamWriter(cryptoStream);
            streamWriter.WriteLine(output);

            streamWriter.Close();
            cryptoStream.Close();
            fileStream.Close();
        }

        ~DataController()
        {
            BaseDESEncode();
        }
    }
}
