namespace BridgePattern
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceImplementor implementor;
        public MailServiceAbstraction()
        {
            implementor = Implementation.GetImplementor();
        }
        public virtual void Send(EmailInformationDto email)
        {
            implementor.SendEmail(email.Reciver, email.Title, email.Message);
        }
    }

}