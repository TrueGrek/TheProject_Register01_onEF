using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TheProject_Register01_onEF
{
    public partial class _default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Roles.DeleteRole("user");
            //Создаём роли
            if (!Roles.IsUserInRole("admin", "admin"))
            {
                Roles.AddUserToRole("admin", "admin");
            }
            const string one = "yandex";
            const string two = "google";
            const string three = "gmail";
            const string four = "admin";
            const string five = "userr";

            if (!Roles.RoleExists(one) || !Roles.RoleExists(two) || !Roles.RoleExists(three) || !Roles.RoleExists(four) || !Roles.RoleExists(five))
            {
                
                Roles.CreateRole(five);
            };
        }

        protected void Page_Unload(object sender, EventArgs e)
        {

        }



       
        
    }
}