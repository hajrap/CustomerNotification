using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Model
{
    //This class  contains response message format.
    public class ResponseMessage
    {
        public string MessageType { get; set; }

        public string[] Data { get; set; }


    }
}
