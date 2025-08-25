using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Validation_And_Password_Encryption_DB_Assignment.Utilities;
using Validation_And_Password_Encryption_DB_Assignment.DataLayer;
using Validation_And_Password_Encryption_DB_Assignment.Entities;

namespace Validation_And_Password_Encryption_DB_Assignment.UI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                User user = new User
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    PasswordHash = SecurityHelper.HashPassword(txtPassword.Text)
                };

                UserRepository repo = new UserRepository();
                repo.AddUser(user);
                Response.Redirect("Login.aspx");
            }
        }

    }
}