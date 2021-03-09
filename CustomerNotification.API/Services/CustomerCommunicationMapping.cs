using CustomerNotification.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Services
{
    public class CustomerCommunicationMapping
    {
        /// <summary>
        /// Get Communication details
        /// </summary>
        /// <returns></returns>
        public CustomerCommunication[] GetCommunicationDetails()
        {

            return new CustomerCommunication[] {
                new CustomerCommunication{ CustomerId="Customer1",FormatType=FormatType.JSON,Channel=Channel.Email},
                new CustomerCommunication{ CustomerId="Customer2",FormatType=FormatType.CSV,Channel=Channel.SMS},
                new CustomerCommunication{ CustomerId="Customer3",FormatType=FormatType.JSON,Channel=Channel.Email},
                new CustomerCommunication{ CustomerId="Customer4",FormatType=FormatType.CSV,Channel=Channel.SMS},
                new CustomerCommunication{ CustomerId="Customer5",FormatType=FormatType.XML,Channel=Channel.Email}
            };
        }
    }
}
