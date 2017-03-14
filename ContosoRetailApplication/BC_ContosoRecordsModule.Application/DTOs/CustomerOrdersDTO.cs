﻿namespace BC_ContosoRecordsModule.Application.DTOs
{
    public class CustomerOrdersDTO
    {
        public string ProductCategoryName { get; set; }
        public string ProductSubcategory { get; set; }
        public string Product { get; set; }
        public int CustomerKey { get; set; }
        public string Region { get; set; }
        public int? Age { get; set; }
        public string IncomeGroup { get; set; }
        public int CalendarYear { get; set; }
        public int FiscalYear { get; set; }
        public int Month { get; set; }
        public string OrderNumber { get; set; }
        public int? LineNumber { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
