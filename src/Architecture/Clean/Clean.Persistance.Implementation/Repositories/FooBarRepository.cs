using Clean.Domain.Entities;
using Clean.Persistance.Contracts.Repositories;

using System;
using System.Collections.Generic;

namespace Clean.Persistance.Implementation.Repositories
{
    public class FooBarRepository : IFooBarRepository
    {
        public IReadOnlyList<FooBar> Get(int name)
        {
            throw new NotImplementedException();
        }
    }
}
