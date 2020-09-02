using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheProject_Register01_onEF
{
    public partial class _default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Unload(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["LoginSS"] = inputLogin.Text;
            Session["PasswordSS"] = inputPassword.Text;
            Session.Timeout = 30;
            try
                {

                using (Database1Entities1 db = new Database1Entities1())
                {
                    SqlParameter pLogin = new SqlParameter("@Login", inputLogin.Text);
                    SqlParameter pPassword = new SqlParameter("@Password", inputPassword.Text);
                    var user = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login And Password = @Password", pLogin, pPassword).Count();

                    if (user != 0)
                    {
                        Response.Redirect("~/Table.aspx");
                    }
                    else
                    {
                        Label1.Visible = true;
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