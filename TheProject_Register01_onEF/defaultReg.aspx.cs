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
    public partial class defaultReg : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Unload(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["LoginSS"] = inputLogin2.Text;
                Session["PasswordSS"] = inputPassword2.Text;
                Session.Timeout = 30;
                Label1.Visible = false;
                try
                {
                   

                    using (Database1Entities1 db = new Database1Entities1())
                    {
                        SqlParameter pLogin = new SqlParameter("@Login", inputLogin2.Text);
                        SqlParameter pPassword = new SqlParameter("@Password", inputPassword2.Text);

                        SqlParameter pLogin2 = new SqlParameter("@Login", inputLogin2.Text);
                        SqlParameter pPassword2 = new SqlParameter("@Password", inputPassword2.Text);
                        //Делаем проверку, нет ли такого логина в системе.
                        var phone = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login", pLogin).Count();

                        if (phone == 0)
                        {
                            User newUser = new User();
                            newUser.Login = (string)pLogin2.Value;
                            newUser.Password = (string)pPassword2.Value;
                            db.Users.Add(newUser);
                            db.SaveChanges(); //db.SaveChanges() сгенерирует выражение INSERT для вставки модели в таблицу.
                            Response.Redirect("~/default.aspx");
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
    }
