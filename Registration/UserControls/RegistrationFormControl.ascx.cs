using Registration.FormService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration.UserControls
{
    public partial class RegistrationFormControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetFormData(FormData Formdata)
        {

            txtName.Value = Formdata.Name;
            txtEmail.Value = Formdata.Email;
            txtDob.Value = Formdata.Dob;
            txtGender.Value = Formdata.Gender;
            txtCountry.Value = Formdata.Country;
            txtMeal.Value = Formdata.Meal;


            //Response.Redirect("FormData.aspx");
        }
    }
}