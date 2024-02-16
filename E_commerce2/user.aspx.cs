using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce2
{
    public partial class Page2 : System.Web.UI.Page
    {
        concls ob = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = " select max(Reg_id) from Login";
            string se = ob.fn_scalar(sel);
            int reg_id = 0;
            if (se == "")
            {
                reg_id = 1;
            }
            else
            {
                int n = Convert.ToInt32(se);
                reg_id = n + 1;
            }
            string ins = "insert into user_reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "'," + TextBox5.Text + ",'" + TextBox6.Text + "','" + DropDownList1.SelectedItem.Value + "','" + DropDownList2.SelectedItem.Value + "')";
            int i = ob.fn_Nonquery(ins);
            string inslog = "insert into Login values(" + reg_id + ",'" + TextBox7.Text + "','" + TextBox9.Text + "','user','active')";
            int j = ob.fn_Nonquery(inslog);
            if (i == 1)
            {
                Label2.Text = "REGISTERED";
            }

        }
    }
}