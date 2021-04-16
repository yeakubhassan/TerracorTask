using System;
namespace TerracorTask
{
    public class SalesOrderDetails
    {
        private SalesOrders orderID;
        private int sequence;
        private string description;
        private double price;

        /*
         * constructor
         */
        public SalesOrderDetails(SalesOrders salesOrder, int seq, string desc, double price_)
        {
            orderID = salesOrder;
            sequence = seq;
            description = desc;
            price = price_;
        }

        /*
         * getters and setters for the attributes
         */
        public SalesOrders OrderID { get => orderID; set => orderID = value; }
        public int Sequence { get => sequence; set => sequence = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
    }
}
