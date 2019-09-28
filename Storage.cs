using System;
using System.Collections.Generic;

namespace PassWord
{

    public class Storage
    {
       
        public int Selection { get; set; }
        public Storage()
        {
         
           
        }

        public void Create(int selec) //this will analyze the selection and pass as an argument to the corresponding method
        {
            switch (selec)
            {
                case 1:
                    AddUser();
                    break;

            }
            
        }

        public void AddUser()
        {
            Console.WriteLine("What is the username you'd like to store?");
            UserAccount.UserName = Console.ReadLine();
            
            Console.WriteLine("What is the password you'd like to store?");
            UserAccount.Password = Console.ReadLine();
            UserAccount.di.Add(UserAccount.UserName, UserAccount.Password);
            //UserAccount.AddUser();
            UserAccount.AddUser();
            




        }
    

       
    }

  
}