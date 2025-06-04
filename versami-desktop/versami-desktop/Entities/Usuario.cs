using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class Usuario
    {
        private String userName, userLogin, userEmail, userPass;
        private int userID;

        public String getUserName()
        {
            return userName;
        }

        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public String getUserLogin()
        {
            return userLogin;
        }

        public void setUserLogin(String userLogin)
        {
            this.userLogin = userLogin;
        }

        public String getUserEmail()
        {
            return userEmail;
        }

        public void setUserEmail(String userEmail)
        {
            this.userEmail = userEmail;
        }

        public String getUserPass()
        {
            return userPass;
        }

        public void setUserPass(String userPass)
        {
            this.userPass = userPass;
        }

        public int getUserID()
        {
            return userID;
        }

        public void setUserID(int userID)
        {
            this.userID = userID;
        }
    }
}
