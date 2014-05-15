namespace HomeWork.Bank
{
    public class PrivateClient : Customer
    {
        public PrivateClient()
        {
            this.currentClient = ClientType.Private;
        }
    }
}