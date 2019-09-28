using System;

namespace PassWord
{
    public static class Print
    {
        public static void Menu()
        {
            Console.WriteLine(
                "Please select one option\n1.Establish an account\n2.Authenticate a user\n3.Exit the system");
        }

        public static void Menu1()
        {
            Console.WriteLine("Enter your new username");
            Console.WriteLine("Enter your new password");
        }
    }
}