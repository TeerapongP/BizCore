using BizCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace BizCore.AppDbContexts
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        // Define DbSet properties representing database tables
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<FinancialReports> FinancialReports { get; set; }
        public DbSet<FinancialTransactions> FinancialTransactions { get; set; }
        public DbSet<MachineAndMaintenance> MachineAndMaintenance { get; set; }
        public DbSet<Machines> Machines { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<PayrollAndBenefits> PayrollAndBenefits { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> User { get; set; }
    }
}