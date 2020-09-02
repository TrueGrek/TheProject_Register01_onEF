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
    public partial class Table : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           

            try
            {

                using (Database1Entities1 db = new Database1Entities1())
                {
                    string al = Session["LoginSS"].ToString();
                    string bl = Session["PasswordSS"].ToString();

                    SqlParameter pLogin = new SqlParameter("@Login", al);
                    SqlParameter pPassword = new SqlParameter("@Password", bl);

                    SqlParameter pLogin2 = new SqlParameter("@Login", al);
                    SqlParameter pPassword2 = new SqlParameter("@Password", bl);


                    var idUser = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login And Password = @Password", pLogin, pPassword).Any();
                    if (idUser)
                    {
                        var x = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login And Password = @Password", pLogin2, pPassword2).ToList();
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

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlCommand command = new SqlCommand
                //("INSERT INTO Tables (IdUser, Domens) VALUES(@Id, @Domens)", _connectionn);
                //// Инициализация переменных в запросе.

                //command.Parameters.AddWithValue("Id", TextBox1.Text);
                //command.Parameters.AddWithValue("Domens", DropDownList1.SelectedValue);

                //// Выполнение запроса.

                //command.ExecuteNonQuery();


                Label1.Visible = true;
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }
    }
    }
