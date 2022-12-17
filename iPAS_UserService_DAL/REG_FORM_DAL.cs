using System;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace iPAS_UserService_DAL
{
    public class REG_FORM_DAL
    {
        #region SetFormData //working👍
        public static IDataReader SetFormData(Database db, string Name, string Email, string Dob, string Country, string Gender, string Meal)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("INSERT INTO REG_FORM(NAME,EMAIL,DOB,COUNTRY,GENDER,MEAL) VALUES(:Name, :Email, :DOB, :Country, :Gender, :Meal)");

            DbCommand dbCmd = db.GetSqlStringCommand(sqlQuery.ToString());
            dbCmd.CommandType = CommandType.Text;

            db.AddInParameter(dbCmd, ":Name", DbType.String, Name);
            db.AddInParameter(dbCmd, ":Email", DbType.String, Email);
            db.AddInParameter(dbCmd, ":DOB", DbType.String, Dob);
            db.AddInParameter(dbCmd, ":Country", DbType.String, Country);
            db.AddInParameter(dbCmd, ":Gender", DbType.String, Gender);
            db.AddInParameter(dbCmd, ":Meal", DbType.String, Meal);

            return db.ExecuteReader(dbCmd);
        }
        #endregion

        #region UpdateFormData //sql query needed🛠️
        public static IDataReader UpdateFormData(Database db, string Name, string Email, string Dob, string Country, string Gender, string Meal)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("");

            DbCommand dbCmd = db.GetSqlStringCommand(sqlQuery.ToString());
            dbCmd.CommandType = CommandType.Text;

            return db.ExecuteReader(dbCmd);
        }
        #endregion

        #region GetFormData //working👍
        public static IDataReader GetFormDataByName(Database db, String name)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("SELECT * FROM REG_FORM WHERE NAME = :Name");

            DbCommand dbCmd = db.GetSqlStringCommand(sqlQuery.ToString());
            dbCmd.CommandType = System.Data.CommandType.Text;

            db.AddInParameter(dbCmd, ":Name", DbType.String, name);

            //IDataReader row = db.ExecuteReader(dbCmd);
            //DataTable row = db.ExecuteDataSet(dbCmd).Tables[0];

            return db.ExecuteReader(dbCmd);
        }
        #endregion

    }
}
