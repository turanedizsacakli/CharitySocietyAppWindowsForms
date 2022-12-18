using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.DependencyResolvers
{
    public class InstanceFactory 
    {
        public static T GetInstance<T>()
        {
            var kernel=new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
