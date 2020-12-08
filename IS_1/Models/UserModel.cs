using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_1.Models
{
    public class UserModel
    {
        public String Login { get; set; }
        public String Password { get; set; }
        public int AuthCnt { get; set; }
        public Boolean Rule { get; set; }
        public Boolean PasswordRestriction { get; set; }
    }
}
