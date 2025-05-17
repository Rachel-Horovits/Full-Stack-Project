using Dal.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Api;

public interface IAddress:Icurd<Address>
{
    public int DalCreateAndGetAddressId(Address item);    
}

