using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReportsForOZHIdev.Logic;
using Microsoft.AspNet.Identity;
using ReportsForOZHIdev.Models;

namespace ReportsForOZHIdev.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RoleActions roleActions = new RoleActions();
            //List<ApplicationUser> users = roleActions.GetUserList();
        }
    }
}