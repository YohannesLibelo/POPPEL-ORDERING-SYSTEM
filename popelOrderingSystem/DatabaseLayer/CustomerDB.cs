using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using popelOrderingSystem.BusinessLayer;

namespace popelOrderingSystem.DatabaseLayer
{
    public class CustomerDB : DB
    {
        #region  Data members 
        private string table1 = "tradeCustomer";
        private string sqllocal1 = "SELECT * FROM tradeCustomer";
        private string table2 = "smallBusiness";
        private string sqllocal2 = "SELECT * FROM smallBusiness";
        private string table3 = "retailers";
        private string sqllocal3 = "SELECT * FROM retailers";
        private Collection<Customer> customers;
        #endregion

        #region Property Method: Collection
        public Collection<Customer> Allcustomer
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqllocal1, table1);
            Add2Collection(table1);
            FillDataSet(sqllocal2, table2);
            Add2Collection(table2);
            FillDataSet(sqllocal3, table3);
            Add2Collection(table3);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            DataRow myRow = null;

            Customer aCus;
            tradeCustomer trCus;
           
            smallBusiness smCus;
            retailers reCus;


            CustomerType.ShopType provValue = CustomerType.ShopType.tradeCustomer;

            switch (table)
            {
                case "tradeCustomer":
                    provValue = CustomerType.ShopType.tradeCustomer;
                    break;
                case "smallBusiness":
                    provValue = CustomerType.ShopType.smallBusiness;
                    break;
                case "retailers":
                    provValue = CustomerType.ShopType.retailers;
                    break;
            }
            //READ from the table 
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aCus = new Customer(provValue);
                    aCus.getName = Convert.ToString(myRow["Name"]).TrimEnd();
                    aCus.getCustomerNumber = Convert.ToString(myRow["CustomerNumber"]).TrimEnd();
                    aCus.getphone = Convert.ToString(myRow["Phonenumber"]).TrimEnd();
                    aCus.getemail = Convert.ToString(myRow["email"]).TrimEnd();
                    aCus.getAddress = Convert.ToString(myRow["Address"]).TrimEnd();
                    aCus.getCredit = Convert.ToDecimal(myRow["CustomerCreditLimit"]);
                    aCus.getblackListed = Convert.ToString(myRow["BlackListed"]);
                  




                    switch (aCus.Cuscat.getCustomervalue)
                    {
                        case CustomerType.ShopType.tradeCustomer:
                            trCus = (tradeCustomer)aCus.Cuscat;
                            trCus.getDescription = Convert.ToString(myRow["CustomerType"]).TrimEnd();
                            break;

                        case CustomerType.ShopType.retailers:
                            reCus = (retailers)aCus.Cuscat;
                            reCus.getDescription = Convert.ToString(myRow["CustomerType"]).TrimEnd();
                            break;
                        case CustomerType.ShopType.smallBusiness:
                            smCus = (smallBusiness)aCus.Cuscat;
                            smCus.getDescription = Convert.ToString(myRow["CustomerType"]).TrimEnd();
                            break;
                    }
                    customers.Add(aCus);
                }
            }
        }
        private void FillRow(DataRow aRow, Customer aCus, DB.DBOperation operation) //populate the row
        {

            //Customer customer;
            //tradeCustomer trCus;
            //smallBusiness smCus;
            //retailers reCus;


            if (operation == DB.DBOperation.Add)
            {
                aRow["CustomerNumber"] = aCus.getCustomerNumber;
            }
            aRow["Name"] = aCus.getName;
            aRow["Phonenumber"] = aCus.getphone;
            aRow["Address"] = aCus.getAddress;
            aRow["Email"] = aCus.getemail;
            aRow["CustomerCreditLimit"] = aCus.getCredit;
            aRow["BlackListed"] = aCus.getCredit;

            


            //switch (aCus.Cuscat.getCustomervalue)
            //{
            //    case CustomerType.ShopType.tradeCustomer:
            //        trCus = (tradeCustomer)aCus.Cuscat;
            //        aRow["description"] = trCus.getDescription;
            //        break;
            //    case CustomerType.ShopType.retailers:
            //        reCus = (retailers)aCus.Cuscat;
            //        aRow["description"] = reCus.getDescription;
            //        break;
            //    case CustomerType.ShopType.smallBusiness:
            //        smCus = (smallBusiness)aCus.Cuscat;
            //        aRow["description"] = smCus.getDescription;
            //        break;
            //}
        }

        private int FindRow(Customer aCus, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aCus.getCustomerNumber == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["CustomerNumber"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Customer aCus, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            switch (aCus.Cuscat.getCustomervalue)
            {
                case CustomerType.ShopType.tradeCustomer:
                    dataTable = table1;
                    break;

                case CustomerType.ShopType.smallBusiness:
                    dataTable = table2;
                    break;
                case CustomerType.ShopType.retailers:
                    dataTable = table3;
                    break;
            }
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aCus, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCus, dataTable)];
                    FillRow(aRow, aCus, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCus, dataTable)];
                    FillRow(aRow, aCus, operation);
                    break;
            }


        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Customer aCus)
        {

            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CustomerNumber", SqlDbType.NVarChar, 10, "CustomerNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phonenumber", SqlDbType.NVarChar, 15, "Phonenumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            daMain.InsertCommand.Parameters.Add(param);


            param = new SqlParameter("@CustomerCreditLimit", SqlDbType.NVarChar, 15, "CustomerCreditLimit");
            daMain.InsertCommand.Parameters.Add(param);



            param = new SqlParameter("@BlackListed", SqlDbType.NVarChar, 15, "BlackListed");
            daMain.InsertCommand.Parameters.Add(param);


            
        }
        private void Build_UPDATE_Parameters(Customer aCus)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            //Do for all fields other than Customernumber 


            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phonenumber", SqlDbType.NVarChar, 15, "Phonenumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CustomerCreditLimit", SqlDbType.NVarChar, 15, "CustomerCreditLimit");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


            param = new SqlParameter("@BlackListed", SqlDbType.NVarChar, 15, "BlackListed");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            


            switch (aCus.Cuscat.getCustomervalue)
            {

                case CustomerType.ShopType.tradeCustomer:
                    param = new SqlParameter("@CustomerType", SqlDbType.NVarChar, 100, "CustomerType");
                    daMain.InsertCommand.Parameters.Add(param);
                    break;
                case CustomerType.ShopType.smallBusiness:
                    param = new SqlParameter("@CustomerType", SqlDbType.NVarChar, 100, "CustomerType");
                    daMain.InsertCommand.Parameters.Add(param);
                    break;
                case CustomerType.ShopType.retailers:
                    param = new SqlParameter("@CustomerType", SqlDbType.NVarChar, 100, "CustomerType");
                    daMain.InsertCommand.Parameters.Add(param);
                    break;
            }
            //testing the CustomerID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "CustomerNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

        }

        private void Build_DElETE_Parameters(Customer aCus)
        {
            //---Create Parameters to communicate with SQL DELETE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);


            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);

            param = new SqlParameter("@Phonenumber", SqlDbType.NVarChar, 15, "Phonenumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);


            switch (aCus.Cuscat.getCustomervalue)
            {

                case CustomerType.ShopType.tradeCustomer:
                    param = new SqlParameter("@CustomerType", SqlDbType.NVarChar, 100, "CustomerType");
                    daMain.InsertCommand.Parameters.Remove(param);
                    break;
                case CustomerType.ShopType.smallBusiness:
                    param = new SqlParameter("@CustomerType", SqlDbType.NVarChar, 100, "CustomerType");
                    daMain.InsertCommand.Parameters.Remove(param);
                    break;
                case CustomerType.ShopType.retailers:
                    param = new SqlParameter("@CustomerType", SqlDbType.NVarChar, 100, "CustomerType");
                    daMain.InsertCommand.Parameters.Remove(param);
                    break;
            }
            //testing the CustomerID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "CustomerNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);


        }
        public void Create_INSERT_Command(Customer aCus)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Customer(Name,CustomerNumber,Phonenumber,Address,Email,CustomerCreditLimit,BlackListed)VALUES (@Name,@CustomerNumber,@Phonenumber,@Address,@Email,@CustomerCreditLimit,@BlackListed)", cnMain);
            Build_INSERT_Parameters(aCus);
        }


        public void Create_UPDATE_Command(Customer aCus)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE  Customer SET Name =@Name,CustomerNumber =@CustomerNumber, Phonenumber=@Phonenumber,Address=@Address,Email =@Email" + "WHERE CustomerNumber = @Original_ID", cnMain);
            Build_UPDATE_Parameters(aCus);
        }


        private void Create_Delete_Command(Customer aCus)
        {
            //Create the command that must be used to delete values from  the table

            daMain.DeleteCommand = new SqlCommand("DELETE FROM Customer(Name,CustomerNumber,Phonenumber,Address,Email)VALUES (@Name,@CustomerNumber,@Phonenumber,@Address,@Email)", cnMain);
            Build_DElETE_Parameters(aCus);

        }


        public bool UpdateDataSource(Customer aCus)
        {
            bool success = true;
            Create_INSERT_Command(aCus);
            Create_UPDATE_Command(aCus);
           // Create_Delete_Command(aCus);

            switch (aCus.Cuscat.getCustomervalue)
            {
                case CustomerType.ShopType.tradeCustomer:
                    success = UpdateDataSource(sqllocal1, table1);
                        break;
                case CustomerType.ShopType.smallBusiness:
                    success = UpdateDataSource(sqllocal1, table1);
                    break;
                case CustomerType.ShopType.retailers:
                    success = UpdateDataSource(sqllocal1, table1);
                    break;

            }

            return success;
        }
        #endregion
    }
}

