﻿using Postgre.Entities.Concrete;
using System.Collections.Generic;

namespace Postgre.DataAccess.Concrete
{
    public interface IPersonDal
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
        Person Get(int id);
        List<Person> GetAll();
    }
}