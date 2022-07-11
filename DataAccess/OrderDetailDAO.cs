using BusinessObject;
using DataAccess.Access;
using System.Data;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAL
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            IDataReader dataReader = null;
            var orders = new List<OrderDetail>();
            string SQLSelect = "select OrderId, ProductId, UnitPrice, Quantity, Discount from OrderDetail";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrderDetail
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetInt32(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetFloat(4),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orders;
        }
    }
}