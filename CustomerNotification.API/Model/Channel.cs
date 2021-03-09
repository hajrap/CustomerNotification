namespace CustomerNotification.API
{
    /// <summary>
    /// This class  contains different channel for customer notification
    /// </summary>
   public enum Channel
    {
        SMS,
        Email,
        HTTP,
        MSQueue,
        FTP,
        SFTP
    }
}