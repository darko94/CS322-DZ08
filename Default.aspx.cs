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
        FacebookUserDao facebookUserDao = new FacebookUserDaoImpl();
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
            facebookUser.Birthday = slctDay.Value + "." + slctMonth.Value + "." + slctYear.Value + ".";
            facebookUser.Gender = radioFemale.Checked ? radioFemale.Value : radioMale.Checked ? radioMale.Value : "";

            if (facebookUserDao.AddFacebookUser(facebookUser))
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "FuncOK()", true);
                txtFirstName.Value = "";
                txtLastName.Value = "";
                txtMobileOrEmail.Value = "";
                txtPassword.Value = "";
                slctDay.Value = "30";
                slctMonth.Value = "3";
                slctYear.Value = "1994";
                radioFemale.Checked = false;
                radioMale.Checked = false;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "FuncNotOK()", true);
            }
            
        }
    }
}