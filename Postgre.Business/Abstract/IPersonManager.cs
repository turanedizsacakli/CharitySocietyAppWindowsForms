﻿using Postgre.Entities.Concrete;
using System.Collections.Generic;

namespace Postgre.Business.Concrete
{
    public interface IPersonManager
    {
        List<Person> GetAll();
    }
}