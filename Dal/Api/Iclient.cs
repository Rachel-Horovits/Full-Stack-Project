using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Api
{
    public interface Iclient:Icurd<Client>
    {
        public Client GetClientById(string username, string id);

        

        }

    }
