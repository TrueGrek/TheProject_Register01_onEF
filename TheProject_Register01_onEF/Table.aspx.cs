using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace TheProject_Register01_onEF
{
    public partial class Table : System.Web.UI.Page
    {
        Database1Entities context = new Database1Entities();

        protected void Page_Load(object sender, EventArgs e)
        {

            string yser = Membership.GetUser().UserName.ToString();
            Label3.Text = yser;

            string[] userArrayRoles = Roles.GetRolesForUser(yser);
            Repeater1.DataSource = userArrayRoles;
            Repeater1.DataBind();
            try
            {

                using (Database1Entities db = new Database1Entities())
                {

                    //Сначала я добавляю пользователя в бд
                    string al = Membership.GetUser().UserName.ToString();
                    SqlParameter pLogin = new SqlParameter("@Login", al);
                    SqlParameter pLogin2 = new SqlParameter("@Login", al);
                    SqlParameter pLogin3 = new SqlParameter("@Login", al);

                    var idUser = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login", pLogin2).Any();
                    if (idUser)
                    {
                        var x = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login", pLogin3).ToList();
                        foreach (var item in x)
                        {
                            Session["idSS"] = item.Id;
                        }
                        string cl = Session["idSS"].ToString();
                        SqlParameter pId = new SqlParameter("@IdUser", cl);
                        var idUserChoosen = db.Database.SqlQuery<Table>("SELECT * FROM Tables where IdUser=@IdUser", pId).Any();
                        if (!idUserChoosen)
                        {
                            Label2.Visible = true;
                        }
                    }


                }

            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }

        }

        protected void Page_Unload(object sender, EventArgs e)
        {
        }

       

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Membership.GetUser().UserName.ToString();
                if (Roles.IsUserInRole(a, "yandex") || Roles.IsUserInRole(a, "admin"))
                {
                    Response.Redirect("~/Userr/Yandex/Yandex.aspx");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Label1.Visible = true;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Membership.GetUser().UserName.ToString();
                if (Roles.IsUserInRole(a, "gmail") || Roles.IsUserInRole(a, "admin"))
                {
                    Response.Redirect("~/Userr/Gmail/Gmail.aspx");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Label1.Visible = true;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Membership.GetUser().UserName.ToString();
                if (Roles.IsUserInRole(a, "admin") || Roles.IsUserInRole(a, "admin"))
                {
                    Response.Redirect("~/Admin/Admin.aspx");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                Label1.Visible = true;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try { 

            string a = Membership.GetUser().UserName.ToString();
            if (Roles.IsUserInRole(a, "google") || Roles.IsUserInRole(a, "admin"))
            {
                Response.Redirect("~/Userr/Google/Google.aspx");
            }
                else
                {
                    throw new Exception();
                }
                
            }
            catch
            {
                Label1.Visible = true;
            }
        }
    }
    }
