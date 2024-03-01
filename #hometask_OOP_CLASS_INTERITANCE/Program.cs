namespace _hometask_OOP_CLASS_INTERITANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                #region task1
                Account login1 = new Account();
                Console.WriteLine("username yaz:");
                login1.Usernameadmin = Console.ReadLine();
               Console.WriteLine("surname yaz:");
                login1.Usersurname = Console.ReadLine();
                Console.WriteLine("email adressi yaz:");
                login1.Usermailadress = Console.ReadLine();
                Console.WriteLine("password-u yaz:");
                login1.Userpassword = Console.ReadLine();

                if (login1.Usernameadmin == "EA18yr@" && login1.Userpassword == "EA18yr@")
                    Console.WriteLine("ugurlu giris");
                else
                {
                    Console.WriteLine("username ve password sehvdir.");
                }
                #endregion
                #region task2
                //facebooksignup signup = new facebooksignup();
                //Console.WriteLine("username yaz:");
                //signup.Usernameadmin = Console.ReadLine();
                //Console.WriteLine("surname yaz:");
                //signup.Usersurname = Console.ReadLine();
                //Console.WriteLine("email adressi yaz:");
                //signup.Usermailadress = Console.ReadLine();
                //Console.WriteLine("password-u yaz:");
                //signup.Userpassword =Console.ReadLine();
                //Console.WriteLine("gender-i qeyd edin:male||famale");
                //signup.Usergender = Console.ReadLine();
                ////signup.Userbirthaday="25052005"
                //Console.WriteLine("phone number-i yaz:");
                //signup.Userphonenumber = Console.ReadLine();

                #endregion





            }
        }

    }

}

