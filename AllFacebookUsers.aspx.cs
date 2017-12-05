using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS322_DZ08
{
    public partial class AllFacebookUsers : System.Web.UI.Page
    {
        FacebookUserDao facebookUserDao = new FacebookUserDaoImpl();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<FacebookUser> list = facebookUserDao.GetAllFacebookUsers();

            TableHeaderRow thRow = new TableHeaderRow();
            table.Rows.Add(thRow);

            TableHeaderCell thCell1 = new TableHeaderCell();
            thCell1.Text = "First name";
            TableHeaderCell thCell2 = new TableHeaderCell();
            thCell2.Text = "Last name";
            TableHeaderCell thCell3 = new TableHeaderCell();
            thCell3.Text = "Mobile or email";
            TableHeaderCell thCell4 = new TableHeaderCell();
            thCell4.Text = "Birthday";
            TableHeaderCell thCell5 = new TableHeaderCell();
            thCell5.Text = "Gender";

            thRow.Cells.Add(thCell1);
            thRow.Cells.Add(thCell2);
            thRow.Cells.Add(thCell3);
            thRow.Cells.Add(thCell4);
            thRow.Cells.Add(thCell5);

            foreach (FacebookUser facebookUser in list)
            {
                


                TableRow tableRow = new TableRow();
                table.Rows.Add(tableRow);
                table.GridLines = GridLines.Both;

                TableCell tableCell1 = new TableCell();
                tableCell1.Text = facebookUser.FirstName;
                TableCell tableCell2 = new TableCell();
                tableCell2.Text = facebookUser.LastName;
                TableCell tableCell3 = new TableCell();
                tableCell3.Text = facebookUser.MobileOrEmail;
                TableCell tableCell4 = new TableCell();
                tableCell4.Text = facebookUser.Birthday;
                TableCell tableCell5 = new TableCell();
                tableCell5.Text = facebookUser.Gender;
                tableRow.Cells.Add(tableCell1);
                tableRow.Cells.Add(tableCell2);
                tableRow.Cells.Add(tableCell3);
                tableRow.Cells.Add(tableCell4);
                tableRow.Cells.Add(tableCell5);
                
            }

            
        }

        protected void dataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}