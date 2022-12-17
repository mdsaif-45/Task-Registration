using Registration.BLL;
using Registration.FormService;
using Registration.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Web.UI.HtmlControls;

namespace Registration.WebServices
{
    /// <summary>
    /// Summary description for RegistrationService
    /// </summary>
    [WebService(Namespace = "http://registrationuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class RegistrationService : System.Web.Services.WebService
    {

        #region Welcome
        [WebMethod]
        public string Welcome()
        {
            return "Hello boss you are inside web service method (=>file.asmx)";
        }
        #endregion


        #region RegistrationForm web service method
        [WebMethod]
        public string RegistrationForm(FormData Formdata)
        {
            // sending data to wcf service by using BLL
            UserServiceBLL BLL = new UserServiceBLL();
            FormData fdata = BLL.SendRegistrationData(Formdata);

            // dynamic creation of page and form           
            System.Web.UI.Page page = new System.Web.UI.Page();
            HtmlForm form = new HtmlForm();

            // loading usercontrol
            RegistrationFormControl userControl = (RegistrationFormControl)page.LoadControl("~/UserControls/RegistrationFormControl.ascx");

            //userControl.ID = "UC01";
            userControl.SetFormData(fdata);

            form.Controls.Add(userControl);
            page.Controls.Add(form);

            // convert page obj to string html
            StringWriter textWriter = new StringWriter();
            HttpContext.Current.Server.Execute(page, textWriter, false);
            textWriter.Close();
            // end

            return CleanHtml(textWriter.ToString())+"<br><hr><h2>"+fdata.Status+"</h2>";
        }
        #endregion


        #region Learning Times = Get current Time 
        [WebMethod]
        public string GetTime(string name)
        {
            return "<br>Hello " + name + Environment.NewLine + " <br> Time: " + DateTime.Now;

        }
        #endregion


        #region Clean HTML string ..remove (tags which not neccessary)
        public static string CleanHtml(string html)
        {
            html = Regex.Replace(html, @"<[/]?(form|[ovwxp]:\w+)[^>]*?>", "", RegexOptions.IgnoreCase);
            html = Regex.Replace(html, @"<script\b[^<]*(?:(?!<\/script>)<[^<]*)*<\/script>", "", RegexOptions.IgnoreCase);
            html = html.Replace("class=\"aspNetHidden\"", "class='aspNetHidden'");
            html = Regex.Replace(html.Trim(), @"<div class='aspNetHidden'>[^&;]*?</div>", "", RegexOptions.IgnoreCase);
            return html.Trim();
        }
        #endregion
    }
}
