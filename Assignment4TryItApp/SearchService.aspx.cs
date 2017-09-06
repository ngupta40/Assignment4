using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4TryItApp
{
    public partial class SearchService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Visible = false;
            Assignment4Services.Service1Client searchsvc = new Assignment4Services.Service1Client();
            Label3.Text = searchsvc.search(TextBox1.Text, TextBox2.Text);
            Label3.Visible = true;
        }
    }
}