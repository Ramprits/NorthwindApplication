// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace NorthwindDemo.Interfaces
{
    using NorthwindDemo.Entities;

    public interface INorthwindDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        System.Data.Entity.DbSet<Category> Categories { get; set; }
        System.Data.Entity.DbSet<CategorySalesFor1997> CategorySalesFor1997 { get; set; }
        System.Data.Entity.DbSet<CurrentProductList> CurrentProductLists { get; set; }
        System.Data.Entity.DbSet<Customer> Customers { get; set; }
        System.Data.Entity.DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        System.Data.Entity.DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        System.Data.Entity.DbSet<Employee> Employees { get; set; }
        System.Data.Entity.DbSet<Invoice> Invoices { get; set; }
        System.Data.Entity.DbSet<Order> Orders { get; set; }
        System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; }
        System.Data.Entity.DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        System.Data.Entity.DbSet<OrdersQry> OrdersQries { get; set; }
        System.Data.Entity.DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        System.Data.Entity.DbSet<Product> Products { get; set; }
        System.Data.Entity.DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        System.Data.Entity.DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; }
        System.Data.Entity.DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        System.Data.Entity.DbSet<Region> Regions { get; set; }
        System.Data.Entity.DbSet<SalesByCategory> SalesByCategories { get; set; }
        System.Data.Entity.DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        System.Data.Entity.DbSet<Shipper> Shippers { get; set; }
        System.Data.Entity.DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        System.Data.Entity.DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        System.Data.Entity.DbSet<Supplier> Suppliers { get; set; }
        System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; }
        System.Data.Entity.DbSet<Territory> Territories { get; set; }

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        
        // Stored Procedures
        System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId);
        System.Collections.Generic.List<CustOrderHistReturnModel> CustOrderHist(string customerId, out int procResult);
        System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId);
        System.Collections.Generic.List<CustOrdersDetailReturnModel> CustOrdersDetail(int? orderId, out int procResult);
        System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId);
        System.Collections.Generic.List<CustOrdersOrdersReturnModel> CustOrdersOrders(string customerId, out int procResult);
        System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate);
        System.Collections.Generic.List<EmployeeSalesByCountryReturnModel> EmployeeSalesByCountry(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult);
        System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate);
        System.Collections.Generic.List<SalesByYearReturnModel> SalesByYear(System.DateTime? beginningDate, System.DateTime? endingDate, out int procResult);
        System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear);
        System.Collections.Generic.List<SalesByCategoryReturnModel> SalesByCategory(string categoryName, string ordYear, out int procResult);
        System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts();
        System.Collections.Generic.List<TenMostExpensiveProductsReturnModel> TenMostExpensiveProducts(out int procResult);
    }

}
// </auto-generated>
