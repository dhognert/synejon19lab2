using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace synejon19lab2
{
    public partial class AdventureWorks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //bel1.Text = "This is Page_Load";
            if (!User.Identity.IsAuthenticated)
                Response.Redirect("~/");

            //(LoginView1.FindControl("Label2") as Label).Text = "I am " + User.Identity.Name + " and I can find the control!";
            if (!IsPostBack)
            {
                BindData();
            }
            //Console.WriteLine("Hello!");

        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Response.Write("grdPerson_RowDeleting");

            int id = int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = GridView1.Rows[e.RowIndex];

            var db = new AdventureWorks2019Entities();
            var item = db.DatabaseLog.Where(x => x.DatabaseLogID == id).First();
            db.DatabaseLog.Remove(item);

            //var pid = new Guid("A948E590-4A56-45A9-BC9A-160A1CC9D990");
            //var person = db.Person.Where(x => x.rowguid == pid).First();
            //db.Person.Remove(person);

            //var personphone = db.PersonPhone.Where(x => x.Person.rowguid == pid).ToList();
            //db.PersonPhone.RemoveRange(personphone);

            //var emailAddress = db.EmailAddress.Where(x => x.Person.rowguid == pid).ToList();
            //db.EmailAddress.RemoveRange(emailAddress);

            db.SaveChanges();
            BindData();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Response.Write("grdPerson_RowEditing");
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Response.Write("GridView1_RowUpdating");
            int id = int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = GridView1.Rows[e.RowIndex];

            TextBox textPostTime = (TextBox)row.Cells[0].Controls[0];
            TextBox textEvent = (TextBox)row.Cells[1].Controls[0];
            GridView1.EditIndex = -1;

            var db = new AdventureWorks2019Entities();
            var item = db.DatabaseLog.Where(x => x.DatabaseLogID == id).First();
            item.PostTime = DateTime.Parse(textPostTime.Text);
            item.Event = textEvent.Text;

            db.SaveChanges();
            BindData();



        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
            //Response.Write("grdPerson_RowCancelingEdit");
        }

        protected void BindData()
        {
            var db = new AdventureWorks2019Entities();
            var dblog = from log in db.DatabaseLog select log;
            if (dblog != null)
            {
                GridView1.DataSource = dblog.ToList();
                GridView1.DataBind();
            }

        }

    }
}