using iPAS_UserService_DAL;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using iPAS_UserService.Model;

namespace iPAS_UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FormService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FormService.svc or FormService.svc.cs at the Solution Explorer and start debugging.
    public class FormService : IFormService
    {
        #region Welcome
        public String Welcome(string name)
        {
            return "Hello " + name;
        }
        #endregion

        #region receiving registration form data from client 
        public FormData RegistrationFormData(FormData data)
        {
            Database db = DatabaseFactory.CreateDatabase("ApplicationConnection");
            REG_FORM_DAL.SetFormData(db, data.Name, data.Email, data.Dob, data.Country, data.Gender, data.Meal);

            IDataReader tableReader = null;
            FormData formDataFromDB = new FormData();
            try
            {
                tableReader = REG_FORM_DAL.GetFormDataByName(db, data.Name);

                tableReader.Read();

                formDataFromDB.Name = tableReader.GetValue(0) as string;
                formDataFromDB.Email = tableReader.GetValue(1) as string;
                formDataFromDB.Dob = tableReader.GetValue(2) as string;
                formDataFromDB.Country = tableReader.GetValue(3) as string;
                formDataFromDB.Gender = tableReader.GetValue(4) as string;
                formDataFromDB.Meal = tableReader.GetValue(5) as string;
                formDataFromDB.Status = "success";

                tableReader.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (tableReader != null && !tableReader.IsClosed)
                {
                    tableReader.Close();
                }
            }

            return formDataFromDB;
        }
        #endregion

        #region calculate days
        public int CalculateDays(int day, int Month, int year)
        {
            DateTime dt = new DateTime(year, Month, day);
            int datetodays = DateTime.Now.Subtract(dt).Days;
            return datetodays;
        }
        #endregion
    }
}

