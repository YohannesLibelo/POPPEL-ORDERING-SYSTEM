using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using popelOrderingSystem.Properties;

namespace popelOrderingSystem.DatabaseLayer
{
    public class DB
    {
        #region Variable declaration
        private string strConn = Settings.Default.CustomerDataBaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        protected SqlCommand command;
        #endregion

        #region CRUD Enumeration
        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2,
            AddtoOrder= 3,


        }
        #endregion

        #region Constructor

        public DB()
        {
            try
            {

                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
                command = new SqlCommand();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Fills dataset fresh from the db for a specific table and with a specific Query        
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }
        #endregion

        #region Update the data source 

        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                cnMain.Open();
                #region Update the database table via the data adapter
                daMain.Update(dsMain, table);

                
                FillDataSet(sqlLocal, table); //refresh the dataset using the SQL statement; and the Table from which the query will emanate from
                success = true;
                cnMain.Close();
                #endregion
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion
    }
}
