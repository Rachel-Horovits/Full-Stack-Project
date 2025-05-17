using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IBLManager
    {
        public IBLClient BLClient { get;}
        public IBLDoctor BLDoctor { get;}
        public IBLAppointment BLAppointment { get; }

        public IBLAddress BLAddress { get; }

    }
}
