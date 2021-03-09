using CustomerNotification.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Services
{
    public class CustomerRepository
    {
        /// <summary>
        /// Get Customer  data
        /// </summary>
        /// <returns></returns>
        public Customer[] GetAllcustomer() {

            return new Customer[] {
                         new Customer{
                             Type=MessageType.UserDeleted,
                             Fields= new Field[]
                                            { new Field{Name="UserId",
                                                DataType="string",
                                                Data="Customer1"}
                                            }
                         },
                         new Customer{
                             Type=MessageType.UserDeleted,
                             Fields= new Field[]
                                            { new Field{Name="UserId",
                                                DataType="string",
                                                Data="Customer2"}
                                            }
                         },
                         new Customer{
                             Type=MessageType.NewUserRegistered,
                             Fields= new Field[]
                                            { new Field{Name="UserId",
                                                DataType="string",
                                                Data="Customer3"},
                                              new Field{Name="Email",
                                                DataType="string",
                                                Data="Customer3@test.com"}
                                              ,
                                              new Field{Name="Firstname",
                                                DataType="string",
                                                Data="Abc"}
                                              ,
                                              new Field{Name="LastName",
                                                DataType="string",
                                                Data="customer"}
                                            }
                         },
                         new Customer{
                             Type=MessageType.UserBlocked,
                             Fields= new Field[]
                                            { new Field{Name="UserId",
                                                DataType="string",
                                                Data="Customer4"}
                                            }
                         }
            };
        }
    }
}
