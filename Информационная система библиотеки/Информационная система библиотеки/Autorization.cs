using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Информационная_система_библиотеки
{
    class Autorization
    {
    private
        string LoginAdministator_;
        string PasswordAdministator_;
        string LoginUser_;
        string PasswordUser_;
        public
        string GetLoginAdministator()
        {
            return LoginAdministator_;
        }
        string GetPasswordAdministator()
        {
            return PasswordAdministator_;
        }
        string GetLoginUser()
        {
            return LoginUser_;
        }
        string GetPasswordUser()
        {
            return PasswordUser_;
        }
    }
}
