using Autofac;
using AutofacDemo.Model;

namespace AutofacDemo.Controller //-> no new 
{
    public class Controller
    {
        public void Control()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SMSService>().As<IMobileService>();//first registered class
            builder.RegisterType<EmailService>().As<IMailService>();//first registered class

            var container = builder.Build();

            container.Resolve<IMobileService>().Execute(); //use
            container.Resolve<IMailService>().Execute();   //use
        }
    }
}
