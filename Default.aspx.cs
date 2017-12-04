using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CS322_DZ08
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            FacebookUser facebookUser = new FacebookUser();
            facebookUser.FirstName = txtFirstName.Value;
            facebookUser.LastName = txtLastName.Value;
            facebookUser.MobileOrEmail = txtMobileOrEmail.Value;
            facebookUser.Password = txtPassword.Value;
            facebookUser.Birthday = slctDay.Value + "." + slctMonth.Value + "." + slctYear.Value;
            facebookUser.Gender = radioFemale.Checked ? radioFemale.Value : radioMale.Checked ? radioMale.Value : "Nije odabran pol.";

            txtMobileOrEmail.Value = facebookUser.FirstName + " " + facebookUser.LastName + " " + facebookUser.Gender;
            
        }
    }
}