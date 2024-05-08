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
    public class OrderDB : DB
    {
        #region  Data members 
        private string table6 = "Order";
        private string sqllocal6 = "SELECT * FROM [Order]";
        private Collection<Order> orders;
        Customer customer;
        Product product;

        #endregion

        #region Property Method: Collection
        public Collection<Order> Allorders
        {
            get
            {
                return orders;
            }
        }
        #endregion

        #region Constructor
        public OrderDB() : base()
        {
            orders = new Collection<Order>();

            FillDataSet(sqllocal6, table6);
            //Add2Collection(table6);

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

            Order anOrd;
          

            Processing Pro;
            Collected Col;



            OrderStatus.orderType ordvValue = OrderStatus.orderType.Collected;
           




            //READ from the table 
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    anOrd = new Order(ordvValue);
                    anOrd.getProductId = Convert.ToString(myRow["productId"]).Trim();
                    anOrd.getProductName = Convert.ToString(myRow["ProductName"]).TrimEnd();
                    anOrd.getOrderQty = Convert.ToString(myRow["orderQty"]).TrimEnd();
                    anOrd.getOrderPrice = Convert.ToString(myRow["orderPrice"]).TrimEnd();
                    anOrd.getOrderTot = Convert.ToString(myRow["orderTot"]).TrimEnd();




                    switch (anOrd.orderTy.getorderStatus)
                    {
                        case OrderStatus.orderType.Collected:
                            Col = (Collected)anOrd.orderTy;
                            Col.getDescription = Convert.ToString(myRow["orderStatus"]).TrimEnd();
                            break;
                        case OrderStatus.orderType.Processing:
                            Pro = (Processing)anOrd.orderTy;
                            Pro.getDescription = Convert.ToString(myRow["orderStatus"]).TrimEnd();
                            break;
                    }
                    orders.Add(anOrd);
                }
               
            }
            
        }

        private void FillRow(DataRow aRow, Customer aCus, Product aPro, Order anOrd, DB.DBOperation operation)
        {


            if (operation == DB.DBOperation.Add)
            {
               
                aRow["ProductName"] = anOrd.getProductName;
                aRow["productId"] = aPro.getProductID;
            }

            aRow["orderPrice"] = anOrd.getOrderPrice;
            aRow["orderQty"] = anOrd.getOrderQty;
            aRow["orderTot"] = anOrd.getOrderTot;
           


        }
        private int FindRow( Product aPro, string table)
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
        public void DataSetChange( Order anOrd,  DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table6;
            Customer aCus = null;
            Product aPro = null ;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aCus, aPro, anOrd, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow( aPro, dataTable)];
                    FillRow(aRow, aCus, aPro, anOrd, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow( aPro, dataTable)];
                    FillRow(aRow, aCus, aPro, anOrd, operation);
                    break;
            }
        }
        #endregion

       

        #region Build Parameters, Create Commands & Update database
       
        private void Build_UPDATE_Parameters(Product aPro)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@orderQty", SqlDbType.NVarChar, 100, "orderQty");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

        }

        public void Create_UPDATE_Command(Product aPro)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE  Product SET orderQty =@orderQty" /*+ "WHERE CustomerNumber = @Original_ID*/,cnMain);
            Build_UPDATE_Parameters(aPro);
        }

        public bool UpdateDataSource(Product aPro)
        {
            bool success = true;
         
            Create_UPDATE_Command(aPro);

            return success;
        }
        #endregion

    }
}
