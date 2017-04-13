using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_C_SHARP
{
    class UserController : Controller<User, UserView>
    {
        protected override void transferDataInView()
        {
            View.UserName = Model.Name;
            View.UserEmail = Model.Email;
        }
    }
}
