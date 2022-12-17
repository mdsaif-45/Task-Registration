using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration
{
    public partial class RegistrationForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GetTime(string name)
        {
            return "Hello " + name + Environment.NewLine + " Now time is: " + DateTime.Now.ToString();
        }
    }
}