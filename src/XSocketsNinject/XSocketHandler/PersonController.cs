using Ninject;
using XSockets.Core.XSocket;
using XSocketsNinject.Core.Interfaces.Service;
using XSocketsNinject.Core.Model;
using XSocketsNinject.Service;

namespace XSocketHandler
{
    public class PersonController : XSocketController
    {
        [Inject] private IPersonService PersonService;

        private static IKernel kernel;
        static PersonController()
        {
            //Create the kernel once
            kernel = new StandardKernel(new ServiceModule());            
        }

        public PersonController()
        {
            //When a new insatnce/connection is made get the Service
            this.PersonService = kernel.Get<PersonService>();
        }


        //A test-method to call from a client... Will save a new Person
        public void Test(Person p)
        {
            this.PersonService.SaveOrUpdate(p);
        }
    }
}
