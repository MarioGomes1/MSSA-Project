using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWord
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Print.Menu(); //offers the user a menu
            int selection = Convert.ToInt32(Console.ReadLine()); //stores selection
             
            var storage = new Storage();
            storage.Create(selection);
            int i = 0;
            while (i < 10)
            {
                Print.Menu();
                int selection1 = Convert.ToInt32(Console.ReadLine());
                storage.Create(selection1);
                
                i++;
            }

        }





    }
}

    
