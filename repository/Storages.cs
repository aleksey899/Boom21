using Boom21.Domains;
using System.Xml.Serialization;





namespace Boom21.repository
{
    public static class Storages
    {
        public static Storage<AgencyAccount> AgencyAccountStorage { get; } = new();
        public static Storage<Customer> CustomerStorage { get; } = new();
        public static Storage<DescriptionOfTheObject> DescriptionOfTheObjectStorage { get; } = new();
        public static Storage<EstateАgent> EstateАgentStorage { get; } = new();
        public static Storage<LogOfRequestsFor> LogOfRequestsForStorage { get; } = new();
        public static Storage<MonetaryAccounting> MonetaryAccountingStorage { get; } = new();
        public static Storage<RealEstateObject> RealEstateObjectStorage { get; } = new();
        public static Storage<Sale> SaleStorage { get; } = new();
        public static Storage<Seller> SellerStorage { get; } = new();
        public static Storage<Transaction> TransactionStorage { get; } = new();
    }
}