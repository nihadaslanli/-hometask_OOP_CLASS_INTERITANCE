using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _hometask_OOP_CLASS_INTERITANCE
{
    internal class Account
    {

        public string Usernameadmin;
        public string Usersurname;
        public string Usermailadress;
        public string Userpassword;


        public void Gmail()
        {
            Console.WriteLine(Usermailadress + "" + Userpassword);
        }
    }
}
