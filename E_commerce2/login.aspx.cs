using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce2
{
    public partial class Page1 : System.Web.UI.Page
    {
        concls ob = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(reg_Id) from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string a = ob.fn_scalar(sel);
            int b = Convert.ToInt32(a);
            if (b == 1)
            {
                string c = "select reg_id from login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                // Response.Redirect("W1.aspx");
                Label3.Text = "success";
            }
        }
    }
}