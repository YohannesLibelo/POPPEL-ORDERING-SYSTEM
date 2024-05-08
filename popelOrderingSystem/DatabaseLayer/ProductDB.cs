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
    public  class ProductDB:DB
    {
        #region  Data members 
       
        private string table4 = "confectionery";
        private string sqllocal4 = "SELECT * FROM confectionery";
        private string table5 = "softdrinks";
        private string sqllocal5 = "SELECT * FROM softdrinks";


        private Collection<Product> products;
        #endregion

        #region Property Method: Collection
        public Collection<Product> Allproduct
        {
            get
            {
                return products;
            }
        }
        #endregion

        #region Constructor
        public ProductDB() : base()
        {
            products = new Collection<Product>();
            FillDataSet(sqllocal4, table4);
            Add2Collection(table4);
            FillDataSet(sqllocal5, table5);
            Add2Collection(table5);
            
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
            Product aProd;
            Confectionery conf;
            Softdrinks sofdri;

            productCategory.productType prodValue = productCategory.productType.nOcateegory;
            

            switch (table)
            {
                case "confectionery":
                    prodValue = productCategory.productType.confectionery;               
                    break;
                case "softdrinks":
                    prodValue = productCategory.productType.softdrinks;
                    break;
            }
            //READ from the table 
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aProd = new Product(prodValue);
                    aProd.getName = Convert.ToString(myRow["Name"]).TrimEnd();
                    aProd.getProductID = Convert.ToString(myRow["ProductNumber"]).TrimEnd();
                    aProd.getPrice = Convert.ToString(myRow["Price"]).TrimEnd();
                    aProd.getQty = Convert.ToString(myRow["Quantity"]).TrimEnd();
                   aProd.getExpiryDate =Convert.ToDateTime( myRow[5]);
                    



                    switch (aProd.category.getCategoryvalue)
                    {
                        
                        case productCategory.productType.confectionery:
                            conf = (Confectionery)aProd.category;
                            conf.getDescription= Convert.ToString(myRow["Category"]).TrimEnd();
                            break;
                        case productCategory.productType.softdrinks:
                            sofdri = (Softdrinks)aProd.category;
                            sofdri.getDescription = Convert.ToString(myRow["Category"]).TrimEnd();
                            break;
                    }
                    products.Add(aProd);
                }
            }
        }

        private void FillRow(DataRow aRow, Product aPro, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["ProductNumber"] = aPro.getProductID;
            }
            aRow["Name"] = aPro.getName;
            aRow["Price"] = aPro.getPrice;
            aRow["Quantity"] = aPro.getQty;
            aRow["ExpiryDate"] = aPro.getExpiryDate;
           
        }
        private int FindRow(Product aPro, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;


            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aPro.getProductID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ProductNumber"]))
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
        public void DataSetChange(Product aPro, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table4;
            switch (aPro.category.getCategoryvalue)
            {
                case productCategory.productType.confectionery:
                    dataTable = table4;
                    break;
                case productCategory.productType.softdrinks:                        
                    dataTable = table5;
                    break;
            }
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aPro, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aPro, dataTable)];
                    FillRow(aRow, aPro, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aPro, dataTable)];
                    FillRow(aRow, aPro, operation);
                    break;
            }

        }
        #endregion

        #region Build Parameters, DELETE  Commands & Update database
       
     
        private void Build_UPDATE_Parameters(Product aPro)
        {

            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@ProductNumber", SqlDbType.NVarChar, 10, "ProductNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.NVarChar, 100, "Price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Quantity", SqlDbType.NVarChar, 15, "Quantity");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

        }


        private void Build_DElETE_Parameters(Product aPro)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@ProductNumber", SqlDbType.NVarChar, 10, "ProductNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);

            param = new SqlParameter("@Price", SqlDbType.NVarChar, 100, "Price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);

            param = new SqlParameter("@Quantity", SqlDbType.NVarChar, 15, "Quantity");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Remove(param);

            //testing the ProductNumber  of record that needs to change with the original ID of the record
                param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ProductNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

        }
        public void Create_UPDATE_Command(Product aPro)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE  Product SET Name =@Name,ProductNumber =@ProductNumber, Price=@Price,Quantity=@Quantity" + "WHERE ProductNumber = @Original_ID", cnMain);
            Build_UPDATE_Parameters(aPro);
        }


        private void Create_Delete_Command(Product aPro)
        {
            //Create the command that must be used to delete values from  the table

            daMain.DeleteCommand = new SqlCommand("DELETE FROM Product(Name,ProductNumber,Price,Quantity)VALUES (@Name,@ProductNumber,@Price,@Quantity)", cnMain);
            Build_DElETE_Parameters(aPro);

        }

        public bool UpdateDataSource(Product aPro)
        {
            bool success = true;
            Create_UPDATE_Command(aPro);
            Create_Delete_Command(aPro);

            switch (aPro.category.getCategoryvalue)
            {
                case productCategory.productType.confectionery:
                    success = UpdateDataSource(sqllocal4, table4);
                    break;
                case productCategory.productType.softdrinks:
                    success = UpdateDataSource(sqllocal5, table5);
                    break;
            }

            return success;
        }


        #endregion
    }
}
