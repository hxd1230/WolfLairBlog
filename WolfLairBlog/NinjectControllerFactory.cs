using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WolfLairBlog.BusinessLogicLayer;
using WolfLairBlog.IBusinessLogicLayer;

namespace WolfLairBlog
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        private void AddBindings()
        {
            kernel.Bind<IUserService>().To<UserService>();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
    }
}