using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;

namespace PassWord
{
    public class UserAccount
    {
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static Dictionary<string, string> di { get; set; } = new Dictionary<string, string>();

        public UserAccount(Dictionary<string, string> param=null)
        {
            di = param;
            
        }

        public static void AddUser()
        {
           
            
                foreach (KeyValuePair<string, string> element in di)
                {
                    string name = element.Key;
                    string pass = element.Value;
                    Console.WriteLine($"name: {name}, password : {pass}");

                }
            
                
            
           

           

        }

       
    }
}