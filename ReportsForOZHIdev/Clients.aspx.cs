using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReportsForOZHIdev.Models;
using ReportsForOZHIdev.Logic;

namespace ReportsForOZHIdev
{
    public partial class Clients : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string clientAction = Request.QueryString["ClientAction"];
            if (clientAction == "add")
            {
                LabelStatus.Text = "Client saved";
            }
            if (clientAction == "remove")
            {
                LabelStatus.Text = "Client deleted";
            }
        }

        protected void AddClientButton_Click(object sender, EventArgs e)
        {
            // Add client data to DB
            AddClients clients = new AddClients();
            bool addSuccess = clients.AddClient(AddFirstNationName.Text);
            if (addSuccess)
            {
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?ClientAdd=add");
            }
            else
            {
                LabelStatus.Text = "Unable to add new client to database";
            }
        }

        public IQueryable GetClients()
        {
            var _db = new ReportsForOZHIdev.Models.ClientsContext();
            IQueryable query = _db.Clients;
            return query;   
        }
    }
}