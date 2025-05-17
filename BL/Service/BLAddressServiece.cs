using BL.Api;
using Dal.Api;
using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service
{
    public class BLAddressServiece : IBLAddress
    {
        IAddress address;
        public BLAddressServiece(IDal dal)
        {
           address = dal.address;
        }
        public int CreateAndGetAddressId(Address item)
        {
            return address.DalCreateAndGetAddressId(item);
        }


    }
}
