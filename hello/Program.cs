using System;
using System.Net;
using System.Collections.Specialized;
using System.Text;

namespace hello
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            httpReqToServe();
        }

        public static void httpReqToServe()
        {
            string keepProgAlive = "false";
            string username = null;
            while (keepProgAlive == "false")
            {
                Console.Write("Enter Username: ");
                username = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                string url = "http://localhost:8080/test";
                var wb = new WebClient();

                var data = new NameValueCollection();
                data["username"] = username;
                data["password"] = password;

                var response = wb.UploadValues(url, "POST", data);
                keepProgAlive = Encoding.UTF8.GetString(response);

                if (keepProgAlive == "false")
                {
                    Console.WriteLine("Incorrect Credentials!");
                }
            }

            if(keepProgAlive == "true")
            {
                SuccessfulLogin loggedIn = new SuccessfulLogin();
                loggedIn.mainMenu(username);

                
            }

            while(keepProgAlive == "true")
            {
                
            }
        }
    }
}
