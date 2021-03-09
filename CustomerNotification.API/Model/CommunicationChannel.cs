using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Model
{
    //This class contains different communication channels
    public class CustomerCommunication
    {
        public string CustomerId { get; set; }

        public FormatType FormatType { get; set; }

        public Channel Channel { get; set; }
    }
}
