using Dal.Api;
using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    public class AddressService : IAddress
    {
        DatabaseManager db;
        public AddressService(DatabaseManager db)
        {
            this.db = db;
        }
        public int DalCreateAndGetAddressId(Address item)
        {
            var existingAddress = db.Addresses.FirstOrDefault(a =>
                a.City == item.City &&
                a.Street == item.Street &&
                a.HouseNumber == item.HouseNumber);
            if (existingAddress != null)
            {
                return existingAddress.Id;
            }

            Create(item);
            return item.Id;
        }

        public void Create(Address item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            db.Addresses.Add(item);
            db.SaveChanges();
        }


        public void Delete(Address item)
        {
            db.Addresses.Remove(item);
            db.SaveChanges();
        }

       
        public List<Address> Read()
        {
           return db.Addresses.ToList();

        }

        public void Update(Address item)
        {
            var existingAddress = db.Addresses.FirstOrDefault(a => a.Id == item.Id);
            if (existingAddress == null) return;
            existingAddress.City = item.City;
            existingAddress.Street = item.Street;
            existingAddress.HouseNumber = item.HouseNumber;
            db.SaveChanges();
        }

       
    }
}
