﻿namespace HMT_13.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EditOrderModel
    {
        [Required]//todo pn мне кажется, нужно поработать с валидацией этой модели
		public string OrderID { get; set; }

        public string CustomerID { get; set; }

        public string EmployeeID { get; set; }

        public string OrderDate { get; set; }

        public string RequiredDate { get; set; }

        public string ShippedDate { get; set; }

        public string ShipVia { get; set; }

        public string Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }
    }
}