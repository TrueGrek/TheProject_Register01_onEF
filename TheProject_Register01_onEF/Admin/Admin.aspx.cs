using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TheProject_Register01_onEF.Admin
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Visible = false;
            lableErrorHave.Visible = false;
            lableErrorHaveNotUser.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Database1Entities db = new Database1Entities())
                {
                    //Проверяю наличие, такого логина.
                    string a = TextBox1.Text;
                    SqlParameter pLogin = new SqlParameter("@Login", a);
                    var loginUser = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login", pLogin).Any();
                    if (loginUser)
                    {
                        string ChoseDomen = DropDownList1.SelectedValue.Trim();
                        if (!Roles.IsUserInRole(a, ChoseDomen))
                        {
                            Roles.AddUserToRole(a, ChoseDomen);
                            Label1.Visible = true;
                        }
                        else
                        {
                            lableErrorHave.Visible = true;
                        }
                    }
                    else
                    {
                        lableErrorHaveNotUser.Visible = true;
                    }
                    
                }

                
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Table1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Table2.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (Database1Entities db = new Database1Entities())
                {
                    //Проверяю наличие, такого логина.
                    string a = TextBox2.Text;
                    SqlParameter pLogin = new SqlParameter("@Login", a);

                    var loginUser = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login", pLogin).Any();
                    if (loginUser)
                    {
                        string ChoseDomen = DropDownList2.SelectedValue.Trim();
                        if (Roles.IsUserInRole(a, ChoseDomen))
                        {
                            Roles.RemoveUserFromRole(a, ChoseDomen);
                            Label2.Visible = true;
                        }
                        else
                        {
                            Label3.Visible = true;
                        }
                    }
                    else
                    {
                        Label4.Visible = true;
                    }

                }


            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
        }
    }
}