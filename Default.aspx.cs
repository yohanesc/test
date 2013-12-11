using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn.Click += new EventHandler(btn_Click);
            Button1.Click += new EventHandler(Button1_Click);
        }

        void Button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable("Brand");
            dt.Columns.Add("col1");
            dt.Columns.Add("col2");
            dt.Rows.Add("Value1", "Value2");

            var dt2 = new DataTable("Product");
            dt2.Columns.Add("col1");
            dt2.Columns.Add("col2");
            dt2.Rows.Add("Value1", "Value2");
            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);
            ExcelHelper.ToExcel(ds, "test.xls", Page.Response);           
        }

        void btn_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("col");
            ds.Tables.Add(dt);
            ExcelHelper.ToExcel(ds, "test.xls", Page.Response);
            
        }      
    }
}
