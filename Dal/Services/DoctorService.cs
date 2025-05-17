using Dal.Api;
using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dal.Services
{
    public class DoctorService : IDoctor
    {
        DatabaseManager db;
        public DoctorService(DatabaseManager db)
        {
            this.db = db;
        }
        public void Create(Doctor item)
        {
            db.Doctors.Add(item);
            db.SaveChanges();
        }

        public void Delete(Doctor item)
        {
         db.Doctors.Remove(item);
            db.SaveChanges();
        }

        public List<Doctor> Read()
        {
            return db.Doctors.ToList();
        }

        public void Update(Doctor item)
        {
            Doctor d = db.Doctors.FirstOrDefault(d => d.Id == item.Id);
            if (d == null) return;
            d.Id = item.Id;
            d.Name = item.Name;
            d.AddressId = item.AddressId;
            d.Specialization=item.Specialization;
            db.SaveChanges(true);
        }
    }
}
