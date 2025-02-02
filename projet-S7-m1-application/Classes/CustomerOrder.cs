﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_S7_m1_application.Classes
{
    internal class CustomerOrder
    {
        public CustomerOrder()
        {

        }
        public CustomerOrder(int CustomerOrderID, string status, int CustomerID)
        {
            this.Customer = new Customer(CustomerID);
            this.CustomerOrderID = CustomerOrderID;
            this.CustomerID = CustomerID;
            this.status = status;
        }

        public CustomerOrder(int CustomerOrderID, int CustomerID, string status, string orderDate, int idClerk, int idDeliverer, int price)
        {
            this.CustomerOrderID = CustomerOrderID;
            this.CustomerID = CustomerID;
            this.status = status;
            if (status == "ordered") this.IsOrdered = true;
            if (status == "In preparation") this.IsInPreparation = true;
            if (status == "In delivery") this.IsInDelivery = true;
            if (status == "Closed") this.IsClosed = true;
            this.orderDate = orderDate;
            this.idClerk = idClerk;
            this.idDeliverer = idDeliverer;
            this.price = price;
        }

        [JsonProperty("CustomerID")]
        public int CustomerID { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("CustomerOrderID")]
        public int CustomerOrderID { get; set; }

        [JsonProperty("orderDate")]
        public string orderDate { get; set; }

        [JsonProperty("idClerk")]
        public int idClerk { get; set; }

        [JsonProperty("idDeliverer")]
        public int idDeliverer { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }

        [JsonProperty("Customer")]
        public Customer Customer { get; set; }

        public bool IsInPreparation { get; set;} = false;
        public bool IsInDelivery { get; set; } = false;
        public bool IsClosed { get; set; } = false;
        public bool IsOrdered { get; set; } = false;


    }
}


