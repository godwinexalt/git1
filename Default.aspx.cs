using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!File.Exists(Server.MapPath("~/text.txt")))
            File.Create(Server.MapPath("~/text.txt"));

    }
}
