using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_C_SHARP
{
    interface View
    {
        void update();
        void hide();
        void showError(String errorMessage);
    }
}
