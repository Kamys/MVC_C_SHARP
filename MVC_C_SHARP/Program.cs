using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController controller = new UserController();
            controller.Model = new User("Vasa","Vasa@gmail.com");
            controller.View = new UserView();
            controller.update();

            Console.ReadLine();
        }
    }
}
