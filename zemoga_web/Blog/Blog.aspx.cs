using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ComTrans;
using Microsoft.AspNet.Identity;
using Facade;

namespace zemoga_web.Blog
{
    public partial class Blog : System.Web.UI.Page
    {


        Fcd facade = new Fcd();

        protected void Page_Load(object sender, EventArgs e)
        {

            string filter = "6";
            facade.GetItems(filter);

        }



        protected void Save_Click(object sender, EventArgs e)
        {

            BlogClass blog = new BlogClass();
            blog.authorName = User.Identity.GetUserName();
            blog.tittle = txt_tittle.Text;
            blog.content = txt_content.Text;
            blog.date = DateTime.Now;
            blog.status = "P"; // Pending Status

            if (facade.SaveForm(blog))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' Inserted Successfully')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(' Inser Record Failed ')", true);
            }
            Response.Redirect("~/Default.aspx");
        }
    }
}