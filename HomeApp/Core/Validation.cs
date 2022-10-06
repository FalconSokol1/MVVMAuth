using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeApp
{
    internal class Validation
    {
        
        public bool CheckingConditions(string login,string password)
        {
            
            User user = new User(login, password);

            if (user.Login == "rus2312" & user.Password == "sd2182343!") 
                return true;
            else return false;



        }
    }
}
