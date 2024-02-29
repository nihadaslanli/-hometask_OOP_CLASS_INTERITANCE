namespace _hometask_OOP_CLASS_INTERITANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                #region task1
                //Account login1 = new Account();
                //login1.Usernameadmin = "name1";
                //login1.Usersurname = "surname1";
                //login1.Usermailadress = "namesurname1@gmail.com";
                //login1.Userpassword = "skkaskak";

                //if (login1.Usernameadmin == "EA18yr@" && login1.Userpassword == "EA18yr@")
                //    Console.WriteLine("ugurlu giris");
                //else
                //{
                //    Console.WriteLine("username ve password sehvdir.");
                //}
                #endregion
                #region task2
                facebooksignup signup = new facebooksignup();
               signup.Usernameadmin = "name1";
                signup.Usersurname = "surname";
                signup.Usermailadress = "ajaaks@gmail.com";
                signup.Userpassword = "password";
                signup.Usergender = "male||famale";
                //signup.Userbirthaday="25052005"
                signup.Userphonenumber = "+99499999";
                Console.WriteLine(signup.Usernameadmin);
                Console.WriteLine(signup.Usersurname);
                Console.WriteLine(signup.Usermailadress);
                Console.WriteLine(signup.Userpassword);
                //Convert.ToDateTime(Console.WriteLine( signup.Userbirthaday));
                Console.WriteLine(signup.Usergender);
                Console.WriteLine(signup.Userphonenumber);
                #endregion





            }
        }

    }

}

