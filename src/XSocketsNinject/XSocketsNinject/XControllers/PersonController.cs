using System;
using Ninject;
using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Helpers;
using XSocketsNinject.Core.Model;
using XSocketsNinject.Service;

namespace XSocketsNinject.XControllers
{
    public class PeopleController : XSocketController
    {
        private static IKernel kernel;
        static PeopleController()
        {
            //Create the kernel once
            kernel = new StandardKernel(new ServiceModule());
        }

        //A test-method to call from a client... Will save a new Person
        public void Test(Person p)
        {
            try
            {
                //Get an instance when needed.. DO NOT open the connection in the constructor and use it all over your class
                //That would keep a connection open to the database during the lifetime of the controller (not good).
                using (var transaction = kernel.BeginBlock())
                {
                    var service = transaction.Get<PersonService>();
                    service.SaveOrUpdate(p);

                    //Tell all subscribers about the new person....
                    this.SendToAll(p, "test");
                }
            }
            catch (Exception ex)
            {
                this.SendError(ex, "Exception in People.Test :(");
            }
        }
    }
}
