namespace AutofacDemo.Model
{
    public class SMSService : IMobileService
    {
        public void Execute()
        {
            System.Console.WriteLine("This is SMSService");
        }
    }
}
