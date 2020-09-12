using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
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

        protected void OnCreatedUser(object sender, EventArgs e)
        {
            using (Database1Entities db = new Database1Entities())
            {
                string al = CreateUserWizard1.UserName;
                SqlParameter pLogin = new SqlParameter("@Login", al);
                var idUserInTable = db.Database.SqlQuery<User>("SELECT * FROM Users WHERE Login = @Login", pLogin).Any();
                if (!idUserInTable)
                {
                    User u = new User();
                    u.Login = al;
                    db.Users.Add(u);
                    db.SaveChanges();
                }
                Roles.AddUserToRole(al, "userr");
            }
        }
        
    }
}
