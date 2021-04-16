using System;
namespace TerracorTask
{
    public class SalesOrders
    {
        private int orderID;
        private int orderNumber;
        private string userName;

        /*
         * constructor 
         */
        public SalesOrders(int order_id, int order_number, string user_name)
        {
            orderID = order_id;
            orderNumber = order_number;
            userName = user_name;
        }

        /*
         * getter and setter for the attributes;
         */
        public int OrderID { get => orderID; set => orderID = value; }
        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public string UserName { get => userName; set => userName = value; }

    }
}
