using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Boom21.Domains;

namespace Boom21.repository
{
    public class MVID
    {
        public int ID { get; set; }
    }

    public class Storages
    {
        public static Storage<AgencyAccount> AgencyAccountStorage { get; } = new Storage<AgencyAccount>();
        public static Storage<Customer> CustomerStorage { get; } = new Storage<Customer>();
        public static Storage<DescriptionOfTheObject> DescriptionOfTheObjectStorage { get; } = new Storage<DescriptionOfTheObject>();
        public static Storage<Estate¿gent> Estate¿gentStorage { get; } = new Storage<Estate¿gent>();
        public static Storage<LogOfRequestsFor> LogOfRequestsForStorage { get; } = new Storage<LogOfRequestsFor>();
        public static Storage<MonetaryAccounting> MonetaryAccountingStorage { get; } = new Storage<MonetaryAccounting>();
        public static Storage<RealEstateObject> RealEstateObjectStorage { get; } = new Storage<RealEstateObject>();
        public static Storage<Sale> SaleStorage { get; } = new Storage<Sale>();
        public static Storage<Seller> SellerStorage { get; } = new Storage<Seller>();
        public static Storage<Transaction> TransactionStorage { get; } = new Storage<Transaction>();
    }

    public class Storage<St> where St : MVID
    {
        private static string path = typeof(St).Name + ".xml";
        private List<St> storage = new List<St>();

        public Storage() { }

        public void ReadFromXMLFile()
        {
            if (File.Exists(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<St>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                    storage = (List<St>)xs.Deserialize(fs);
            }
        }

        public void SaveToXMLFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<St>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
                xs.Serialize(fs, storage);
        }

        public bool Create(St obj)
        {
            if (storage.Where(t => t.ID == obj.ID).Count() != 0)
                return false;
            storage.Add(obj);
            return true;
        }

        public St Read(int ID)
        {
            if (storage.Where(t => t.ID == ID).Count() != 0)
                return storage.Where(t => t.ID == ID).First();
            return null;
        }

        public St Update(St obj)
        {
            int index = storage.FindIndex(t => t.ID == obj.ID);
            if (index == -1)
                Create(obj);
            else
                storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID)
        {
            return storage.RemoveAll(t => t.ID == objID) != 0;
        }
    }
}
