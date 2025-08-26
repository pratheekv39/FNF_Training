using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Validation_And_Password_Encryption_DB_Assignment.DataLayer;

namespace Validation_And_Password_Encryption_DB_Assignment.UI
{
    public partial class UsersList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserRepository repo = new UserRepository();
                rptUsers.DataSource = repo.GetAllUsers();
                rptUsers.DataBind();
            }
        }

    }
}