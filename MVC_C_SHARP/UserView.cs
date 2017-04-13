using System;

namespace MVC_C_SHARP
{
    public class UserView : View
    {

        private string userName;
        private string userEmail;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string UserEmail
        {
            get
            {
                return userEmail;
            }

            set
            {
                userEmail = value;
            }
        }

        public void hide()
        {
            Console.Clear();
        }

        public void showError(string errorMessage)
        {
            Console.Error.WriteLine(errorMessage);
        }

        public void update()
        {
            Console.WriteLine("User:\n name = {0}\n email = {1}",userName,userEmail);
        }
    }
}