using Dal.Api;
using Dal.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services;

public class ClientService : Iclient
{
    DatabaseManager db;
    public ClientService(DatabaseManager db)
    {
        this.db = db;
    }
    public void Create(Client item)
    {
        var existingClient = db.Clients.FirstOrDefault(c => c.Name == item.Name);

        if (existingClient != null)
        {
            throw new InvalidOperationException("Client already exists.");
        }

        db.Clients.Add(item);
        db.SaveChanges();
    }
    public void Delete(Client item)
    {
        db.Clients.Remove(item);
        db.SaveChanges();
    }
    public List<Client> Read()
    {
        return db.Clients.ToList();
    }
    public void Update(Client item)
    {
        var existingClient = db.Clients.FirstOrDefault(e => e.Id == item.Id);
        if (existingClient == null) return;

        existingClient.LeftEyeNumber = item.LeftEyeNumber;
        existingClient.PhoneNumber = item.PhoneNumber;
        existingClient.RightEyeNumber = item.RightEyeNumber;
        existingClient.AddressId = item.AddressId;
        existingClient.Age = item.Age;
        existingClient.Email = item.Email;
        existingClient.Cylinder = item.Cylinder;

        db.SaveChanges();
    }
    public Client? GetClientById(string username, string id)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(id))
        {
            throw new InvalidOperationException("Data transfer error, please try again.");
        }
        return db.Clients.FirstOrDefault(e => e.Id == id && e.Name == username);
    }
    
}