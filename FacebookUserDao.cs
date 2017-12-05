using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ08
{
    interface FacebookUserDao
    {
        bool AddFacebookUser(FacebookUser facebookUser);
        List<FacebookUser> GetAllFacebookUsers();
    }
}
