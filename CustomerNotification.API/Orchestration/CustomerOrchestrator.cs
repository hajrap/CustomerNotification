using CustomerNotification.API.Model;
using CustomerNotification.API.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Orchestration
{
    public class CustomerOrchestrator
    {
        private CustomerRepository customerRepository;

        private CustomerCommunicationMapping communicationMapping;

        public CustomerOrchestrator()
        {
            this.customerRepository = new CustomerRepository();
            this.communicationMapping = new CustomerCommunicationMapping();
        }
        /// <summary>
        /// Get Customer notification  and process it in require  format
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public async Task<string> ProcessCustomerNotificationMessage(string CustomerId) {
            
            var Customer = this.customerRepository.GetAllcustomer().FirstOrDefault(x => string.Compare(x.Fields.First(x=>x.Name=="UserId").Data, CustomerId) ==0);
            var ResponseType = this.communicationMapping.GetCommunicationDetails().FirstOrDefault(x => string.Compare(x.CustomerId, CustomerId) == 0);
            var responseMessage = new ResponseMessage();
            await Task.FromResult(0);
            if (ResponseType.FormatType == FormatType.JSON)
            {
                return GenerateJson(Customer);
            }
            else if (ResponseType.FormatType == FormatType.CSV)
            {
               return GenerateCsv(Customer.Type.ToString(),CustomerId);
            }
            return null;
        }

        private string GenerateJson(Customer customer) {
            var response = new ResponseMessage {
                MessageType = customer.Type.ToString(),
                Data = customer.Fields.Select(f => string.Format("{0} : {1}", f.Name, f.Data)).ToArray()
        };
            return JsonConvert.SerializeObject(response);
        }

        private string GenerateCsv(string MessageType,string customerId)
        {
            return String.Join(",", MessageType,customerId);
        }
    }
}
