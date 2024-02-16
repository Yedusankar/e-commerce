using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce2
{
    public partial class page3 : System.Web.UI.Page
    {
        concls ob = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_id) from Login";
            string str = ob.fn_scalar(sel);
            int reg_id = 0;
            if (str == "")
            {
                reg_id = 1;
            }
            else
            {
                int c = Convert.ToInt32(str);
                reg_id = c + 1;
            }
            string ins = "insert into Admin_reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";

            int i = ob.fn_Nonquery(ins);
            string log = "insert into Login values(" + reg_id + ",'" + TextBox4.Text + "','" + TextBox6.Text + "','admin','active')";
            int j = ob.fn_Nonquery(log);
            if (i == 1)
            {
                Label6.Text = "INSERTED";
            }
        }
    }
}