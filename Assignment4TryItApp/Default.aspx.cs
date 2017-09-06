using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4TryItApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (TableRow tRow in SvcTable.Rows)
            {
                if (i == 1)
                {
                    TableCell btnCell = new TableCell();
                    Button btn = new Button();
                    btn.Text = "Try It";
                    btn.Click += new EventHandler(InvokeVerificationSvc);
                    btnCell.Controls.Add(btn);
                    tRow.Cells.Add(btnCell);
                }
                if (i == 2)
                {
                    TableCell btnCell = new TableCell();
                    Button btn = new Button();
                    btn.Text = "Try It";
                    btn.Click += new EventHandler(InvokeSearchSvc);
                    btnCell.Controls.Add(btn);
                    tRow.Cells.Add(btnCell);
                }
                i++;
            }
            }

        private void InvokeSearchSvc(object sender, EventArgs e)
        {
            Response.Redirect("SearchService.aspx");
        }

        private void InvokeVerificationSvc(object sender, EventArgs e)
        {
            Response.Redirect("VerificationService.aspx");
        }
    }
}