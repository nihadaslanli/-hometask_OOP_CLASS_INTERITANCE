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
                Console.WriteLine("username yaz:");
                signup.Usernameadmin = Console.ReadLine();
                Console.WriteLine("surname yaz:");
                signup.Usersurname = Console.ReadLine();
                Console.WriteLine("email adressi yaz:");
                signup.Usermailadress = Console.ReadLine();
                Console.WriteLine("password-u yaz:");
                signup.Userpassword =Console.ReadLine();
                Console.WriteLine("gender-i qeyd edin:male||famale");
                signup.Usergender = Console.ReadLine();
                //signup.Userbirthaday="25052005"
                Console.WriteLine("phone number-i yaz:");
                signup.Userphonenumber = Console.ReadLine();
                
                #endregion





            }
        }

    }

}

