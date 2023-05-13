namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RefinedMailService mailService = new RefinedMailService();
            mailService.Send(new EmailInformationDto
            {
                Message = "this is a message from my app ",
                Reciver = "Hassan.olfat@outlook.com",
                Title = "Hello,"
            });

            Console.ReadKey();
        }
    }
}