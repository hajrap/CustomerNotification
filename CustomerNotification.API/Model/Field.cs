namespace CustomerNotification.API.Model
{
    //This class conatins different fields in data part of the message.
    public class Field
    {
        public string Name { get; set; }
        public string DataType { get; set; }

        public string Data { get; set; }
    }
}