using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Validation_And_Password_Encryption_DB_Assignment.Utilities;
using Validation_And_Password_Encryption_DB_Assignment.DataLayer;

namespace Validation_And_Password_Encryption_DB_Assignment.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string passwordHash = SecurityHelper.HashPassword(txtPassword.Text);

            UserRepository repo = new UserRepository();
            if (repo.ValidateUser(username, passwordHash))
            {
                Response.Redirect("UsersList.aspx");
            }
            else
            {
                Response.Write("Invalid credentials.");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }


    }
}