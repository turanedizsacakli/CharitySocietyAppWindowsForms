using Ninject.Modules;
using Postgre.Business.Abstract;
using Postgre.Business.Concrete;
using Postgre.DataAccess.Abstract;
using Postgre.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.DependencyResolvers
{
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonService>().To<PersonManager>();
            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<CategoryDal>();
            Bind<IPersonDal>().To<PersonDal>();

        }
    }
}
