using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReportsForOZHIdev.Models;
using System.Web.ModelBinding;

namespace ReportsForOZHIdev
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<User> GetUser([QueryString("IDUser")] int? IdUser)
        {
            var _db = new ReportsForOZHIdev.Models.ClientsContext();
            IQueryable<User> query = _db.Users;
            if (IdUser.HasValue && IdUser >= 0)
            {
                query.Where(u => u.IDUser == IdUser);
            }
            else
            {
                query = null;
            }
            return query;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}