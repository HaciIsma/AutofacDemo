namespace AutofacDemo.Model
{
    class EmailService : IMailService
    {
        public void Execute()
        {
            System.Console.WriteLine("This is EmailService");
        }
    }
}
