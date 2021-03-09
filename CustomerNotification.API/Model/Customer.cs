using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Model
{
    //This class contains  cutomer notification message format.
    public class Customer
    {
        public MessageType Type { get; set; }
        public Field[] Fields { get; set; }
    }
}
